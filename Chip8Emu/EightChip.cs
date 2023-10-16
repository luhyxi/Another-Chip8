using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Chip8Emu
{
    public class EightChip {
        const int ScreenW = 64, ScreenH = 32; // Window
        byte[] Ram = new byte[0x1000]; // RAM Memory
        char[] gfx = new char[64 * 32]; // Graphics
        Dictionary<byte, Action<OpCodeData>> opCodes; //OpCode
        Dictionary<byte, Action<OpCodeData>> opCodesMisc; //OpCode
        
        /*  Regs and Stuff */
        uint DelayTimer;
        uint SoundTimer;
        byte[] V = new byte[16]; // General purpose regs
        ushort pc = 0x200; // Program Counter
        ushort I; // Index
        ushort[] stack = new ushort[16];
        byte sp; // Stack pointer
        /* End */
        
        Action<bool[,]> draw; // Drawing action
        Action<int> beep;
        HashSet<byte> pressedKeys = new HashSet<byte>(); // Keyboard
        
        //OpCodes
        struct OpCodeData
        {
            public ushort OpCode;
            public ushort NNN;
            public byte NN, X, Y, N;
        }
        
        

        public void Init()
        {
            pc = pc;
            OpCodeData
        }
    }
}