﻿using System;
using System.IO;
using Xunit;

namespace KHSave.Tests
{
    public static class Helpers
    {
        public static void Using<T>(this T disposable, Action<T> action)
            where T : IDisposable
        {
            using (disposable)
                action(disposable);
        }

        public static TResult Using<T, TResult>(this T disposable, Func<T, TResult> func)
            where T : IDisposable
        {
            using (disposable)
                return func(disposable);
        }

        public static void Dump(this Stream stream, string path) =>
            File.OpenWrite(path).Using(outStream =>
            {
                stream.Position = 0;
                stream.CopyTo(outStream);
            });

        public static void AssertStream(Stream expectedStream, Func<Stream, Stream> funcGenerateNewStream)
        {
            var expectedData = expectedStream.ReadAllBytes();
            var actualStream = funcGenerateNewStream(new MemoryStream(expectedData));
            var actualData = actualStream.ReadAllBytes();

            Assert.Equal(expectedData.Length, actualData.Length);

            for (var i = 0; i < expectedData.Length; i++)
            {
                var ch1 = expectedData[i];
                var ch2 = actualData[i];
                Assert.True(ch1 == ch2, $"Expected {ch1:X02} but found {ch2:X02} at {i:X}");
            }
        }

        public static byte[] ReadBytes(Stream stream)
        {
            var data = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(data, 0, data.Length);
            stream.Position = 0;

            return data;
        }

        public static void UseAsset(string assetName, Action<Stream> action) =>
            File.OpenRead(Path.Combine($"_Assets", assetName)).Using(x => action(x));

        public static void Dump(this byte[] data, string path) =>
            new MemoryStream(data).Using(x => x.Dump(path));

        public static void FileOpenRead(string path, Action<Stream> action)
        {
            File.OpenRead(path).Using(x => action(x));
        }
    }
}
