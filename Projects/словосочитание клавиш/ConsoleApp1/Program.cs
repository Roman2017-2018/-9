﻿using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //_serialPort = new SerialPort("COM2");
            //_serialPort.Close(); _serialPort.Close(); _serialPort.Close(); _serialPort.Close(); _serialPort.Close();
            //_serialPort.Open();


           
            ConsoleKey key;
            do
            {
                while (!Console.KeyAvailable)
                {
                    // Do something, but don't read key here
                }

                // Key is available - read it
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.H)
                {
                    int a = 50;
                    int b =100;
                    Thread.Sleep(2000);
                    KeyboardSend.KeyDown(KeyboardSend.Keys.K);
                    Thread.Sleep(b);
                    KeyboardSend.KeyUp(KeyboardSend.Keys.K);
                    Thread.Sleep(a);
                    KeyboardSend.KeyDown(KeyboardSend.Keys.W);
                    Thread.Sleep(b);
                    KeyboardSend.KeyUp(KeyboardSend.Keys.W);
                    Thread.Sleep(a);
                    KeyboardSend.KeyDown(KeyboardSend.Keys.L);
                    Thread.Sleep(b);
                    KeyboardSend.KeyUp(KeyboardSend.Keys.L);
                    Thread.Sleep(250);
                    KeyboardSend.KeyDown(KeyboardSend.Keys.K);
                    Thread.Sleep(b);
                    KeyboardSend.KeyUp(KeyboardSend.Keys.K);
                    Thread.Sleep(a);
                    KeyboardSend.KeyDown(KeyboardSend.Keys.W);
                    Thread.Sleep(b);
                    KeyboardSend.KeyUp(KeyboardSend.Keys.W);
                    Thread.Sleep(a);
                    KeyboardSend.KeyDown(KeyboardSend.Keys.J);
                    Thread.Sleep(b);
                    KeyboardSend.KeyUp(KeyboardSend.Keys.J);
                    Thread.Sleep(a);
                    Console.WriteLine(ConsoleKey.Z.ToString());
                }

/*                   Функция для Наруто
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.H)
                {
                    int a = 50;
                    int b = 50;
                    Thread.Sleep(2000);
                    KeyboardSend.KeyDown(KeyboardSend.Keys.K);
                    Thread.Sleep(100);
                    KeyboardSend.KeyUp(KeyboardSend.Keys.K);
                    Thread.Sleep(50);
                    KeyboardSend.KeyDown(KeyboardSend.Keys.S);
                    Thread.Sleep(100);
                    KeyboardSend.KeyUp(KeyboardSend.Keys.S);
                    Thread.Sleep(50);
                    KeyboardSend.KeyDown(KeyboardSend.Keys.L);
                    Thread.Sleep(100);
                    KeyboardSend.KeyUp(KeyboardSend.Keys.L);
                    Thread.Sleep(50);
                    KeyboardSend.KeyDown(KeyboardSend.Keys.J);
                    Thread.Sleep(a);
                    KeyboardSend.KeyUp(KeyboardSend.Keys.J);
                    Thread.Sleep(b);
                    KeyboardSend.KeyDown(KeyboardSend.Keys.K);
                    Thread.Sleep(a);
                    KeyboardSend.KeyUp(KeyboardSend.Keys.K);
                    Thread.Sleep(b);
                    Console.WriteLine(ConsoleKey.Z.ToString());
                }
                */









                // if (key == ConsoleKey.X)
                //{
                //    Console.WriteLine(ConsoleKey.X.ToString()); _serialPort.Write("1");
                //}
                //if (key == ConsoleKey.C)
                //{
                //    Console.WriteLine(ConsoleKey.C.ToString()); _serialPort.Write("2");
                //}
                //else if (key == ConsoleKey.V)
                //{
                //    Console.WriteLine(ConsoleKey.V.ToString()); _serialPort.Write("3");
                //}

            } while (key != ConsoleKey.Escape);




            //    Thread thread1 = new Thread(Z);
            //Thread thread2 = new Thread(X);
            //Thread thread3 = new Thread(C);
            //Thread thread4 = new Thread(V);
            //thread1.Start();
            //thread2.Start();
            //thread3.Start();
            //thread4.Start();


        }




    }
    static class KeyboardSend
    {

        public enum Keys
        {
            //
            // Сводка:
            //     Битовая маска для извлечения модификаторов из значения клавиши.
            Modifiers = -65536,
            //
            // Сводка:
            //     Нет нажатых клавиш.
            None = 0,
            //
            // Сводка:
            //     Левую кнопку мыши.
            LButton = 1,
            //
            // Сводка:
            //     Правой кнопкой мыши.
            RButton = 2,
            //
            // Сводка:
            //     Ключ "Отмена".
            Cancel = 3,
            //
            // Сводка:
            //     Средняя кнопка мыши (мыши).
            MButton = 4,
            //
            // Сводка:
            //     Первая кнопка мыши (пятикнопочная мышь).
            XButton1 = 5,
            //
            // Сводка:
            //     Вторая кнопка мыши (пятикнопочная мышь).
            XButton2 = 6,
            //
            // Сводка:
            //     Клавиша BACKSPACE.
            Back = 8,
            //
            // Сводка:
            //     Клавиша TAB.
            Tab = 9,
            //
            // Сводка:
            //     Ключ, перевода строки.
            LineFeed = 10,
            //
            // Сводка:
            //     Клавиша CLEAR.
            Clear = 12,
            //
            // Сводка:
            //     Клавиша возврата.
            Return = 13,
            //
            // Сводка:
            //     Клавиша ВВОД.
            Enter = 13,
            //
            // Сводка:
            //     Клавиша SHIFT.
            ShiftKey = 16,
            //
            // Сводка:
            //     Клавиша CTRL.
            ControlKey = 17,
            //
            // Сводка:
            //     Клавиша ALT.
            Menu = 18,
            //
            // Сводка:
            //     Клавиша PAUSE.
            Pause = 19,
            //
            // Сводка:
            //     Клавиша CAPS LOCK.
            Capital = 20,
            //
            // Сводка:
            //     Клавиша CAPS LOCK.
            CapsLock = 20,
            //
            // Сводка:
            //     Клавиша режима "Кана" редактора метода ввода.
            KanaMode = 21,
            //
            // Сводка:
            //     Режим IME Hanguel ключ. (поддерживается для обеспечения совместимости; используйте
            //     HangulMode)
            HanguelMode = 21,
            //
            // Сводка:
            //     Клавиша режима "Хангыль" редактора метода ввода.
            HangulMode = 21,
            //
            // Сводка:
            //     Клавиша режима "Джунджа" редактора метода ввода.
            JunjaMode = 23,
            //
            // Сводка:
            //     Клавиша окончательного режима IME.
            FinalMode = 24,
            //
            // Сводка:
            //     Клавиша режима "Ханджа" редактора метода ввода.
            HanjaMode = 25,
            //
            // Сводка:
            //     Клавиша режима "Кандзи" редактора метода ввода.
            KanjiMode = 25,
            //
            // Сводка:
            //     Клавиша ESC.
            Escape = 27,
            //
            // Сводка:
            //     Клавиша преобразования IME.
            IMEConvert = 28,
            //
            // Сводка:
            //     Клавиша IME без преобразования.
            IMENonconvert = 29,
            //
            // Сводка:
            //     Ключ, заменяет принятия IME System.Windows.Forms.Keys.IMEAceept.
            IMEAccept = 30,
            //
            // Сводка:
            //     Клавиша принятия IME. Является устаревшей, используйте System.Windows.Forms.Keys.IMEAccept
            //     вместо.
            IMEAceept = 30,
            //
            // Сводка:
            //     Клавиша изменения режима IME.
            IMEModeChange = 31,
            //
            // Сводка:
            //     Клавиша ПРОБЕЛ.
            Space = 32,
            //
            // Сводка:
            //     Клавиша PAGE UP.
            Prior = 33,
            //
            // Сводка:
            //     Клавиша PAGE UP.
            PageUp = 33,
            //
            // Сводка:
            //     Клавиша PAGE DOWN.
            Next = 34,
            //
            // Сводка:
            //     Клавиша PAGE DOWN.
            PageDown = 34,
            //
            // Сводка:
            //     Клавиша END.
            End = 35,
            //
            // Сводка:
            //     Клавиша HOME.
            Home = 36,
            //
            // Сводка:
            //     Клавиша СТРЕЛКА ВЛЕВО.
            Left = 37,
            //
            // Сводка:
            //     Клавиша СТРЕЛКА ВВЕРХ.
            Up = 38,
            //
            // Сводка:
            //     Клавиша СТРЕЛКА ВПРАВО.
            Right = 39,
            //
            // Сводка:
            //     Клавиша СТРЕЛКА ВНИЗ.
            Down = 40,
            //
            // Сводка:
            //     Клавиша SELECT.
            Select = 41,
            //
            // Сводка:
            //     Клавиша PRINT.
            Print = 42,
            //
            // Сводка:
            //     Клавиша EXECUTE.
            Execute = 43,
            //
            // Сводка:
            //     Клавиша PRINT SCREEN.
            Snapshot = 44,
            //
            // Сводка:
            //     Клавиша PRINT SCREEN.
            PrintScreen = 44,
            //
            // Сводка:
            //     Клавишу INS.
            Insert = 45,
            //
            // Сводка:
            //     Клавиша DEL.
            Delete = 46,
            //
            // Сводка:
            //     Клавиша HELP.
            Help = 47,
            //
            // Сводка:
            //     Клавиша 0.
            D0 = 48,
            //
            // Сводка:
            //     Клавиша 1.
            D1 = 49,
            //
            // Сводка:
            //     Клавиша 2.
            D2 = 50,
            //
            // Сводка:
            //     Клавиша 3.
            D3 = 51,
            //
            // Сводка:
            //     Клавиша 4.
            D4 = 52,
            //
            // Сводка:
            //     Клавиша 5.
            D5 = 53,
            //
            // Сводка:
            //     Клавиша 6.
            D6 = 54,
            //
            // Сводка:
            //     Клавиша 7.
            D7 = 55,
            //
            // Сводка:
            //     Клавиша 8.
            D8 = 56,
            //
            // Сводка:
            //     Клавиша 9.
            D9 = 57,
            //
            // Сводка:
            //     Клавиша A.
            A = 65,
            //
            // Сводка:
            //     Клавиша B.
            B = 66,
            //
            // Сводка:
            //     Клавиша C.
            C = 67,
            //
            // Сводка:
            //     Клавиша D.
            D = 68,
            //
            // Сводка:
            //     Клавиша E.
            E = 69,
            //
            // Сводка:
            //     Клавиша F.
            F = 70,
            //
            // Сводка:
            //     Клавиша G.
            G = 71,
            //
            // Сводка:
            //     Клавиша H.
            H = 72,
            //
            // Сводка:
            //     Клавиша I.
            I = 73,
            //
            // Сводка:
            //     Клавиша J.
            J = 74,
            //
            // Сводка:
            //     Клавиша K.
            K = 75,
            //
            // Сводка:
            //     Клавиша L.
            L = 76,
            //
            // Сводка:
            //     Клавиша M.
            M = 77,
            //
            // Сводка:
            //     Клавиша N.
            N = 78,
            //
            // Сводка:
            //     Клавиша O.
            O = 79,
            //
            // Сводка:
            //     Клавиша P.
            P = 80,
            //
            // Сводка:
            //     Клавиша Q.
            Q = 81,
            //
            // Сводка:
            //     Клавиша R.
            R = 82,
            //
            // Сводка:
            //     Клавиша S.
            S = 83,
            //
            // Сводка:
            //     Клавиша T.
            T = 84,
            //
            // Сводка:
            //     Клавиша U.
            U = 85,
            //
            // Сводка:
            //     Клавиша V.
            V = 86,
            //
            // Сводка:
            //     Клавиша W.
            W = 87,
            //
            // Сводка:
            //     Клавиша X.
            X = 88,
            //
            // Сводка:
            //     Клавиша Y.
            Y = 89,
            //
            // Сводка:
            //     Клавиша Z.
            Z = 90,
            //
            // Сводка:
            //     Левая клавиша с логотипом Windows (клавиатура Microsoft Natural Keyboard).
            LWin = 91,
            //
            // Сводка:
            //     Правая клавиша с логотипом Windows (клавиатура Microsoft Natural Keyboard).
            RWin = 92,
            //
            // Сводка:
            //     Ключ приложения (клавиатура Microsoft).
            Apps = 93,
            //
            // Сводка:
            //     Ключ спящий режим компьютера.
            Sleep = 95,
            //
            // Сводка:
            //     Клавиша 0 на цифровой клавиатуре.
            NumPad0 = 96,
            //
            // Сводка:
            //     Клавиша 1 на цифровой клавиатуре.
            NumPad1 = 97,
            //
            // Сводка:
            //     Клавиша 2 на цифровой клавиатуре.
            NumPad2 = 98,
            //
            // Сводка:
            //     Клавиша 3 на цифровой клавиатуре.
            NumPad3 = 99,
            //
            // Сводка:
            //     Клавиша 4 на цифровой клавиатуре.
            NumPad4 = 100,
            //
            // Сводка:
            //     Клавиша 5 на цифровой клавиатуре.
            NumPad5 = 101,
            //
            // Сводка:
            //     Клавиша 6 на цифровой клавиатуре.
            NumPad6 = 102,
            //
            // Сводка:
            //     Клавиша 7 на цифровой клавиатуре.
            NumPad7 = 103,
            //
            // Сводка:
            //     Клавиша 8 на цифровой клавиатуре.
            NumPad8 = 104,
            //
            // Сводка:
            //     Клавиша 9 на цифровой клавиатуре.
            NumPad9 = 105,
            //
            // Сводка:
            //     Клавиша умножения.
            Multiply = 106,
            //
            // Сводка:
            //     Добавить ключ.
            Add = 107,
            //
            // Сводка:
            //     Клавиша разделителя.
            Separator = 108,
            //
            // Сводка:
            //     Клавиша минус.
            Subtract = 109,
            //
            // Сводка:
            //     Клавиша десятичного разделителя.
            Decimal = 110,
            //
            // Сводка:
            //     Клавиша деления.
            Divide = 111,
            //
            // Сводка:
            //     Клавиша F1.
            F1 = 112,
            //
            // Сводка:
            //     Клавиша F2.
            F2 = 113,
            //
            // Сводка:
            //     Клавиша F3.
            F3 = 114,
            //
            // Сводка:
            //     Клавиша F4.
            F4 = 115,
            //
            // Сводка:
            //     Клавиша F5.
            F5 = 116,
            //
            // Сводка:
            //     Клавиша F6.
            F6 = 117,
            //
            // Сводка:
            //     Клавиша F7.
            F7 = 118,
            //
            // Сводка:
            //     Клавиша F8.
            F8 = 119,
            //
            // Сводка:
            //     Клавиша F9.
            F9 = 120,
            //
            // Сводка:
            //     Клавиша F10.
            F10 = 121,
            //
            // Сводка:
            //     Клавиша F11.
            F11 = 122,
            //
            // Сводка:
            //     Клавиша F12.
            F12 = 123,
            //
            // Сводка:
            //     Клавиша F13.
            F13 = 124,
            //
            // Сводка:
            //     Клавиша F14.
            F14 = 125,
            //
            // Сводка:
            //     Клавиша F15.
            F15 = 126,
            //
            // Сводка:
            //     Клавиша F16.
            F16 = 127,
            //
            // Сводка:
            //     Клавиша F17.
            F17 = 128,
            //
            // Сводка:
            //     Клавиша F18.
            F18 = 129,
            //
            // Сводка:
            //     Клавиша F19.
            F19 = 130,
            //
            // Сводка:
            //     Клавиша F20.
            F20 = 131,
            //
            // Сводка:
            //     Клавиша F21.
            F21 = 132,
            //
            // Сводка:
            //     Клавиша F22.
            F22 = 133,
            //
            // Сводка:
            //     Клавиша F23.
            F23 = 134,
            //
            // Сводка:
            //     Клавиша F24.
            F24 = 135,
            //
            // Сводка:
            //     Клавиша NUM LOCK.
            NumLock = 144,
            //
            // Сводка:
            //     Ключ SCROLL LOCK.
            Scroll = 145,
            //
            // Сводка:
            //     Левую клавишу SHIFT.
            LShiftKey = 160,
            //
            // Сводка:
            //     Клавиши SHIFT.
            RShiftKey = 161,
            //
            // Сводка:
            //     Левая клавиша CTRL.
            LControlKey = 162,
            //
            // Сводка:
            //     Правая клавиша CTRL.
            RControlKey = 163,
            //
            // Сводка:
            //     Левая клавиша ALT.
            LMenu = 164,
            //
            // Сводка:
            //     Правая клавиша ALT.
            RMenu = 165,
            //
            // Сводка:
            //     Клавиша возврата обозревателя (Windows 2000 или более поздней версии).
            BrowserBack = 166,
            //
            // Сводка:
            //     Ключ вперед обозревателя (Windows 2000 или более поздней версии).
            BrowserForward = 167,
            //
            // Сводка:
            //     Клавиша обновления в обозревателе (Windows 2000 или более поздней версии).
            BrowserRefresh = 168,
            //
            // Сводка:
            //     Клавиша остановки обозревателя (Windows 2000 или более поздней версии).
            BrowserStop = 169,
            //
            // Сводка:
            //     Клавиша поиска обозревателя (Windows 2000 или более поздней версии).
            BrowserSearch = 170,
            //
            // Сводка:
            //     Клавиша избранного обозревателя (Windows 2000 или более поздней версии).
            BrowserFavorites = 171,
            //
            // Сводка:
            //     Клавиша домашней обозревателя (Windows 2000 или более поздней версии).
            BrowserHome = 172,
            //
            // Сводка:
            //     Клавиша выключения звука (Windows 2000 или более поздней версии).
            VolumeMute = 173,
            //
            // Сводка:
            //     Тише ключ (Windows 2000 или более поздней версии).
            VolumeDown = 174,
            //
            // Сводка:
            //     Громче ключ (Windows 2000 или более поздней версии).
            VolumeUp = 175,
            //
            // Сводка:
            //     Затем клавиша клипа (Windows 2000 или более поздней версии).
            MediaNextTrack = 176,
            //
            // Сводка:
            //     Предыдущие клавиша клипа (Windows 2000 или более поздней версии).
            MediaPreviousTrack = 177,
            //
            // Сводка:
            //     Клавиша остановки мультимедиа (Windows 2000 или более поздней версии).
            MediaStop = 178,
            //
            // Сводка:
            //     Клавиша приостановки воспроизведения (Windows 2000 или более поздней версии).
            MediaPlayPause = 179,
            //
            // Сводка:
            //     Клавиша запуска почты (Windows 2000 или более поздней версии).
            LaunchMail = 180,
            //
            // Сводка:
            //     Клавиша выбора записи (Windows 2000 или более поздней версии).
            SelectMedia = 181,
            //
            // Сводка:
            //     Клавиша запуска приложения один (Windows 2000 или более поздней версии).
            LaunchApplication1 = 182,
            //
            // Сводка:
            //     Клавиша запуска приложения два (Windows 2000 или более поздней версии).
            LaunchApplication2 = 183,
            //
            // Сводка:
            //     Ключ точки с запятой ПВТ на стандартной клавиатуре США (Windows 2000 или более
            //     поздней версии).
            OemSemicolon = 186,
            //
            // Сводка:
            //     Клавиша OEM 1.
            Oem1 = 186,
            //
            // Сводка:
            //     Клавиша плюса ПВТ на клавиатуре любой страны или региона (Windows 2000 или более
            //     поздней версии).
            Oemplus = 187,
            //
            // Сводка:
            //     Клавиша запятой ПВТ на клавиатуре любой страны или региона (Windows 2000 или
            //     более поздней версии).
            Oemcomma = 188,
            //
            // Сводка:
            //     OEM минус клавиша на клавиатуре любой страны или региона (Windows 2000 или более
            //     поздней версии).
            OemMinus = 189,
            //
            // Сводка:
            //     Ключ OEM периода на клавиатуре любой страны или региона (Windows 2000 или более
            //     поздней версии).
            OemPeriod = 190,
            //
            // Сводка:
            //     Клавиша вопросительного знака ПВТ на стандартной клавиатуре США (Windows 2000
            //     или более поздней версии).
            OemQuestion = 191,
            //
            // Сводка:
            //     Клавиша OEM 2.
            Oem2 = 191,
            //
            // Сводка:
            //     Клавиша тильды ПВТ на стандартной клавиатуре США (Windows 2000 или более поздней
            //     версии).
            Oemtilde = 192,
            //
            // Сводка:
            //     Клавиша OEM 3.
            Oem3 = 192,
            //
            // Сводка:
            //     Ключ OEM открывающей скобкой на стандартной клавиатуре США (Windows 2000 или
            //     более поздней версии).
            OemOpenBrackets = 219,
            //
            // Сводка:
            //     Клавиша OEM 4.
            Oem4 = 219,
            //
            // Сводка:
            //     Клавиша вертикальной черты ПВТ на стандартной клавиатуре США (Windows 2000 или
            //     более поздней версии).
            OemPipe = 220,
            //
            // Сводка:
            //     Клавиша OEM 5.
            Oem5 = 220,
            //
            // Сводка:
            //     Клавиша закрывающую квадратные скобки ПВТ на стандартной клавиатуре США (Windows
            //     2000 или более поздней версии).
            OemCloseBrackets = 221,
            //
            // Сводка:
            //     Клавиша OEM 6.
            Oem6 = 221,
            //
            // Сводка:
            //     OEM одинарных/двойных кавычек ключа на стандартной клавиатуре США (Windows 2000
            //     или более поздней версии).
            OemQuotes = 222,
            //
            // Сводка:
            //     Клавиша OEM 7.
            Oem7 = 222,
            //
            // Сводка:
            //     Клавиша OEM 8.
            Oem8 = 223,
            //
            // Сводка:
            //     Угловой скобки ПВТ или обратной косой чертой на RT в 102 клавиши (Windows 2000
            //     или более поздней версии).
            OemBackslash = 226,
            //
            // Сводка:
            //     Клавиша OEM 102.
            Oem102 = 226,
            //
            // Сводка:
            //     Клавиша ОБРАБОТКИ.
            ProcessKey = 229,
            //
            // Сводка:
            //     Используется для передачи символов Юникода в виде нажатия клавиш. Значение клавиши
            //     пакета является младшее слово 32-разрядное значение виртуального ключ, используемый
            //     для методов ввода не клавиатуры.
            Packet = 231,
            //
            // Сводка:
            //     Клавиша ATTN.
            Attn = 246,
            //
            // Сводка:
            //     Клавиша CRSEL.
            Crsel = 247,
            //
            // Сводка:
            //     Клавиша EXSEL.
            Exsel = 248,
            //
            // Сводка:
            //     Клавиша ERASE EOF.
            EraseEof = 249,
            //
            // Сводка:
            //     Клавиша PLAY.
            Play = 250,
            //
            // Сводка:
            //     Клавиша ZOOM.
            Zoom = 251,
            //
            // Сводка:
            //     Константа, зарезервированная для использования в будущем.
            NoName = 252,
            //
            // Сводка:
            //     Клавиша PA1.
            Pa1 = 253,
            //
            // Сводка:
            //     Клавиша CLEAR.
            OemClear = 254,
            //
            // Сводка:
            //     Битовая маска для извлечения кода клавиши из значения клавиши.
            KeyCode = 65535,
            //
            // Сводка:
            //     Клавиша SHIFT.
            Shift = 65536,
            //
            // Сводка:
            //     Клавиша CTRL.
            Control = 131072,
            //
            // Сводка:
            //     Клавиша модификатора ALT.
            Alt = 262144
        }


        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private const int KEYEVENTF_EXTENDEDKEY = 1;
        private const int KEYEVENTF_KEYUP = 2;

        public static void KeyDown(Keys vKey)
        {
            keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY, 0);
        }

        public static void KeyUp(Keys vKey)
        {
            keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }
    }
}
