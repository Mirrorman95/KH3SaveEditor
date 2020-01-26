﻿using KHSave.LibRecom;
using KHSave.LibRecom.Models;
using KHSave.LibRecom.Types;
using KHSave.SaveEditor.Common.Contracts;
using KHSave.SaveEditor.KhRecom.Interfaces;
using KHSave.SaveEditor.KhRecom.Models;
using System;
using System.IO;
using Xe.Tools;

namespace KHSave.SaveEditor.KhRecom.ViewModels
{
    public class KhRecomViewModel : BaseNotifyPropertyChanged, IRefreshUi, IOpenStream, IWriteToStream, ICardCountService
    {
        private const int MaxCardIndex = 10;
        private SaveKhRecom _save;
        private DataRecom SaveData => _save.Data;

        public SystemViewModel KhSystem { get; private set; }
        public CardInventoryViewModel Inventory { get; private set; }
        public ProgressViewModel Progress { get; private set; }
        public SettingsViewModel Settings { get; private set; }

        public KhRecomViewModel()
        {
        }

        public void RefreshUi()
        {
            KhSystem = new SystemViewModel(SaveData);
            Inventory = new CardInventoryViewModel(SaveData, this);
            Progress = new ProgressViewModel(SaveData);
            Settings = new SettingsViewModel(SaveData);

            OnPropertyChanged(nameof(SystemViewModel));
            OnPropertyChanged(nameof(CardInventoryViewModel));
            OnPropertyChanged(nameof(ProgressViewModel));
            OnPropertyChanged(nameof(SettingsViewModel));
        }

        public void OpenStream(Stream stream)
        {
            _save = SaveKhRecom.Read(stream);
            RefreshUi();
        }

        public void WriteToStream(Stream stream) => _save.Write(stream);

        public byte GetCardCount(CardType card, CardIndex index, bool isPremium) =>
            OnCard(card, isPremium, x => SaveData.McWork.CardInventoryCount[x + index]);

        public void SetCardCount(CardType card, CardIndex index, bool isPremium, byte count) =>
            OnCard(card, isPremium, x => SaveData.McWork.CardInventoryCount[x + index] = count);

        private T OnCard<T>(CardType card, bool isPremium, Func<int, T> action)
        {
            var index = CardModel.GetCardInventoryIndex(card, isPremium);
            return index >= 0 ? action(index) : default(T);
        }
    }
}
