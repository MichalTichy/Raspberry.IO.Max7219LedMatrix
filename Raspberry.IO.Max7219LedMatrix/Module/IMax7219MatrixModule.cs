﻿using Raspberry.IO.Max7219LedMatrix.CharactersLibrary;

namespace Raspberry.IO.Max7219LedMatrix.Module
{
    public interface IMax7219MatrixModule
    {
        /// <summary>
        /// Module number represents in which order are modules connected.
        /// Lowest module number marks first connected module and the highest marks the last.
        /// Display cannot contain duplicate module numbers.
        /// </summary>
        int ModuleNumber { get; }

        Max7219MatrixModule ApplyPreprocessing();
        void SetCharacterLibrary(IMatrixCharactersLibrary charactersLibrary);
        IMax7219MatrixModule ShiftModuleRight(uint columnCount);
        IMax7219MatrixModule ShiftModuleLeft(uint columnCount);
        IMax7219MatrixModule ShiftModuleUp(uint rowCount);
        IMax7219MatrixModule ShiftModuleDown(uint rowCount);
        IMax7219MatrixModule FlipModuleVertical();
        IMax7219MatrixModule FlipModuleHorizontal();
        IMax7219MatrixModule InvertModule();
        IMax7219MatrixModule SetRow(uint rowId, byte value);
        byte GetRow(uint rowId);
        IMax7219MatrixModule Fill();
        void Set(byte[] data);
        IMax7219MatrixModule SetNumber(int number);
        IMax7219MatrixModule SetCharacter(char character);
        byte[] Get();
        IMax7219MatrixModule ClearModule();
        uint GetRowCount();
        uint GetColumnCount();
        void SetColumn(uint column, byte data);
        byte GetColumn(uint column);
    }
}