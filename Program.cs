///// Mohammad Heydari /////////
//////* Shamsipour Technical and Vocational College (2023) *//////////////


Console.WriteLine("A ? (y or n)");/////*The questions and answers are symbolic and the questions and answers may be different in each context.*/////////////
string input;
LockKeyboardYN();

switch (input) {
    case "y" or "Y":
        Console.WriteLine();
        Console.WriteLine("B ? (y or n)");
        LockKeyboardYN();
        switch (input) {
            case "y" or "Y":
                Console.WriteLine();
                Console.WriteLine("D ? (y or n)");
                LockKeyboardYN();
                switch (input) {
                    case "y" or "Y":
                        Console.WriteLine();
                        Console.WriteLine("F ? (y or n)");
                        LockKeyboardYN();
                        switch (input) {
                            case "y" or "Y":
                                Console.WriteLine();
                                Console.WriteLine("G ? (y or n)");
                                LockKeyboardYN();
                                switch (input) {
                                    case "y" or "Y":
                                        Console.WriteLine();
                                        Console.WriteLine("J ? (y or n)");
                                        LockKeyboardYN();
                                        switch (input) {
                                            case "y" or "Y":
                                                Console.WriteLine();
                                                Console.WriteLine("L ? (y or n)");
                                                LockKeyboardYN();
                                                switch (input) {
                                                    case "y" or "Y":
                                                        Console.WriteLine();
                                                        Console.WriteLine("N21");
                                                        break;
                                                    case "n" or "N":
                                                        Console.WriteLine();
                                                        Console.WriteLine("A.Z");
                                                        break;
                                                }
                                                break;
                                            case "n" or "N":
                                                Console.WriteLine();
                                                Console.WriteLine("H.C");
                                                break;
                                        }
                                        break;
                                    case "n" or "N":
                                        Console.WriteLine();
                                        Console.WriteLine("C.H");
                                        break;
                                }
                                break;
                            case "n" or "N":
                                Console.WriteLine();
                                Console.WriteLine("C.D.Z");
                                break;
                        }
                        break;
                    case "n" or "N":
                        Console.WriteLine();
                        Console.WriteLine("C.A.B");
                        break;
                }
                break;
            case "n" or "N":
                Console.WriteLine();
                Console.WriteLine("Z.C.A");
                break;
        }
        break;
    case "n" or "N":
        Console.WriteLine();
        Console.WriteLine("C ? (y or n)");
        LockKeyboardYN();
        switch (input) {
            case "y" or "Y":
                Console.WriteLine();
                Console.WriteLine("E ? (y or n)");
                LockKeyboardYN();
                switch (input) {
                    case "y" or "Y":
                        Console.WriteLine();
                        Console.WriteLine("H ? (y or n)");
                        LockKeyboardYN();
                        switch (input) {
                            case "y" or "Y":
                                Console.WriteLine();
                                Console.WriteLine("I ? (y or n)");
                                LockKeyboardYN();
                                switch (input) {
                                    case "y" or "Y":
                                        Console.WriteLine();
                                        Console.WriteLine("K ? (y or n)");
                                        LockKeyboardYN();
                                        switch (input) {
                                            case "y" or "Y":
                                                Console.WriteLine();
                                                Console.WriteLine("M ? (y or n)");
                                                LockKeyboardYN();
                                                switch (input) {
                                                    case "y" or "Y":
                                                        Console.WriteLine();
                                                        Console.WriteLine("O22");
                                                        break;
                                                    case "n":
                                                        Console.WriteLine();
                                                        Console.WriteLine("A.S");
                                                        break;
                                                }
                                                break;
                                            case "n":
                                                Console.WriteLine();
                                                Console.WriteLine("U.K");
                                                break;
                                        }
                                        break;
                                    case "n":
                                        Console.WriteLine();
                                        Console.WriteLine("H.Q");
                                        break;
                                }
                                break;
                            case "n":
                                Console.WriteLine();
                                Console.WriteLine("Z.G.Q");
                                break;
                        }
                        break;
                    case "n":
                        Console.WriteLine();
                        Console.WriteLine("Z.G.Q");
                        break;
                }
                break;
            case "n":
                Console.WriteLine();
                Console.WriteLine("A.B.H");
                break;
        }
        break;
}

#region Methods
void LockKeyboardYN() {

    do {
        input = Console.ReadKey(true).KeyChar.ToString();

    } while (input.ToUpper() != "Y" && input.ToUpper() != "N");
    Console.WriteLine(input);
}
#endregion

