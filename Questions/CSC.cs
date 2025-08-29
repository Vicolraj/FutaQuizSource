namespace FutaQuiz.Questions
{


    public class CSC
    {
        public static int BonusTime = 10;
        public static List<QuestionPreset>? Questions_ =
            [
            //CSC101 101 101 101 101 101 101 101 101
            //CSC101 101 101 101 101 101 101 101 101
            //CSC101 101 101 101 101 101 101 101 101
            //CSC101 101 101 101 101 101 101 101 101
            //CSC101 101 101 101 101 101 101 101 101

#region "CSC101"

            new("CSC101")
            {
                QuestionsList =
                [

                    new()
                    {
                        StrQuestion = "What does the disk drive of a computer do?",
                        Options = ["Rotate the disk", "Read the disk", "Load a program from the disk into the memory", "Both b and c"],
                        Answer = "Both b and c",
                    },

                    new()
                    {
                        StrQuestion = "Access time is",
                        Options = ["seek time + latency time", "seek time", "seek time", "latency time"],
                        Answer = "seek time + latency time",
                    },

                    new()
                    {
                        StrQuestion = "Who invented the microprocessor?",
                        Options = ["Marcian E Huff", "Herman H Goldstein", "Joseph Jacquard", "All of above"],
                        Answer = "Marcian E Huff",
                    },

                    new()
                    {
                        StrQuestion = "MICR stands for",
                        Options = ["Magnetic Ink Character Reader", "Magnetic Ink Code Reader", "Magnetic Ink Case Reader", "None of the above"],
                        Answer = "Magnetic Ink Character Reader",
                    },

                    new()
                    {
                        StrQuestion = "The Width of a processor’s data path is measured in bits. Which of the following are common data paths?",
                        Options = ["8 bits", "12 bits", "16 bits", "32 bits"],
                        Answer = "32 bits",
                    },

                    new()
                    {
                        StrQuestion = "MSI is the abbreviation of",
                        Options = ["Medium Scale Integrated", "Medium System Integrated", "Medium Scale Intelligent", "Medium System Intelligent"],
                        Answer = "Medium Scale Integrated",
                    },

                    new()
                    {
                        StrQuestion = "IBM launched its first personal computer called IBM-PC in 1981. It had chips from Intel, disk drives from Tandon, operating system from Microsoft, the printer from Epson and the application software from everywhere. Can you name the country which contributed?",
                        Options = ["India", "China", "Germany", "Taiwan"],
                        Answer = "Taiwan",
                    },

                    new()
                    {
                        StrQuestion = "Which statement is valid about interpreter?",
                        Options = ["It translates one instruction at a time", "Object code is saved for future use", "Repeated interpretation is not necessary", "All of above"],
                        Answer = "It translates one instruction at a time",
                    },

                    new()
                    {
                        StrQuestion = "Easily relocatable language is",
                        Options = ["Machine language", "Assembly language", "High level language", "Medium level language"],
                        Answer = "High level language",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following memories needs refresh?",
                        Options = ["SRAM", "DRAM", "ROM", "All of above"],
                        Answer = "DRAM",
                    },

                    new()
                    {
                        StrQuestion = "Through which device the main components of the computer communicate with each other?",
                        Options = ["Keyboard", "System Bus", "Monitor", "Memory"],
                        Answer = "System Bus",
                    },

                    new()
                    {
                        StrQuestion = "What type of device is computer keyboard?",
                        Options = ["Memory", "Output", "Storage", "Input"],
                        Answer = "Input",
                    },

                    new()
                    {
                        StrQuestion = "Which is the limitation of high level language?",
                        Options = ["Lower efficiency", "Machine dependence", "machine level coding", "None of above"],
                        Answer = "Lower efficiency",
                    },

                    new()
                    {
                        StrQuestion = "An example of a digital device can be",
                        Options = ["Digital clock", "Automobile speed meter", "Clock with a dial and two hands", "All of the above"],
                        Answer = "Digital clock",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not true?",
                        Options = ["Transistors are much smaller", "Transistors produce low heat", "Transistors were less reliable", "Transistors were used in radios and other electronic devices"],
                        Answer = "Transistors were less reliable",
                    },

                ]
            },

            new ("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "UNIVAC is",
                        Options = ["Universal Automatic Computer", "Universal Array Computer", "Unique Automatic Computer", "Unvalued Automatic Computer"],
                        Answer = "Universal Automatic Computer"
                    },
                    new()
                    {
                        StrQuestion = "The basic operations performed by a computer are",
                        Options = ["Arithmetic operation", "Logical operation", "Storage and relative", "All the above"],
                        Answer = "All the above"
                    },
                    new()
                    {
                        StrQuestion = "The two major types of computer chips are",
                        Options = ["External memory chip", "Primary memory chip", "Microprocessor chip", "Both b and c"],
                        Answer = "Both b and c"
                    },
                    new()
                    {
                        StrQuestion = "Microprocessors as switching devices are for which generation computers",
                        Options = ["First Generation", "Second Generation", "Third Generation", "Fourth Generation"],
                        Answer = "Fourth Generation"
                    },
                    new()
                    {
                        StrQuestion = "What is the main difference between a mainframe and a super computer?",
                        Options = [
                            "Super computer is much larger than mainframe computers",
                            "Super computers are much smaller than mainframe computers",
                            "Supercomputers are focused to execute few programs as fast as possible while mainframe uses its power to execute as many programs concurrently",
                            "Supercomputers are focused to execute as many programs as possible while mainframe uses its power to execute few programs as fast as possible"
                        ],
                        Answer = "Supercomputers are focused to execute few programs as fast as possible while mainframe uses its power to execute as many programs concurrently"
                    },
                    new()
                    {
                        StrQuestion = "ASCII and EBCDIC are the popular character coding systems. What does EBCDIC stand for?",
                        Options = [
                            "Extended Binary Coded Decimal Interchange Code",
                            "Extended Bit Code Decimal Interchange Code",
                            "Extended Bit Case Decimal Interchange Code",
                            "Extended Binary Case Decimal Interchange Code"
                        ],
                        Answer = "Extended Binary Coded Decimal Interchange Code"
                    },
                    new()
                    {
                        StrQuestion = "The brain of any computer system is",
                        Options = ["ALU", "Memory", "CPU", "Control unit"],
                        Answer = "CPU"
                    },
                    new()
                    {
                        StrQuestion = "Storage capacity of magnetic disk depends on",
                        Options = ["tracks per inch of surface", "bits per inch of tracks", "disk pack in disk surface", "All of above"],
                        Answer = "All of above"
                    },
                    new()
                    {
                        StrQuestion = "The two kinds of main memory are:",
                        Options = ["Primary and secondary", "Random and sequential", "ROM and RAM", "All of above"],
                        Answer = "ROM and RAM"
                    },
                    new()
                    {
                        StrQuestion = "A storage area used to store data to compensate for the difference in speed at which the different units can handle data is",
                        Options = ["Memory", "Buffer", "Accumulator", "Address"],
                        Answer = "Buffer"
                    },
                    new()
                    {
                        StrQuestion = "IBM 1 401 computer was",
                        Options = ["Mainframe Computer", "Mini Computers", "Micro Computers", "None of above"],
                        Answer = "Mainframe Computer",
                    },

                    new()
                    {
                        StrQuestion = "Time during which a job is processed by the computer is",
                        Options = ["Delay times", "Real time", "Execution time", "Down time"],
                        Answer = "Execution time",
                    },

                    new()
                    {
                        StrQuestion = "CD-ROM stands for",
                        Options = ["Compactable Read Only Memory", "Compact Data Read Only Memory", "Compactable Disk Read Only Memory", "Compact Disk Read Only Memory"],
                        Answer = "Compact Disk Read Only Memory",
                    },

                    new()
                    {
                        StrQuestion = "Which unit converts user data into machine readable form?",
                        Options = ["Input unit", "Output unit", "ALU", "Control Unit"],
                        Answer = "Input unit",
                    },

                    new()
                    {
                        StrQuestion = "Which unit is known as nerve center of computer?",
                        Options = ["ALU", "CU", "Memory", "Registers"],
                        Answer = "CU",
                    },


                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Computer is free from tiresome and boredom. We call it",
                        Options = ["Accuracy", "Reliability", "Diligence", "Versatility"],
                        Answer = "Diligence"
                    },
                    new()
                    {
                        StrQuestion = "Integrated Circuits (ICs) are related to which generation of computers?",
                        Options = ["First generation", "Second generation", "Third generation", "Fourth generation"],
                        Answer = "Third generation"
                    },
                    new()
                    {
                        StrQuestion = "CD-ROM is a",
                        Options = ["Semiconductor memory", "Memory register", "Magnetic memory", "None of above"],
                        Answer = "None of above"
                    },
                    new()
                    {
                        StrQuestion = "A hybrid computer",
                        Options = [
                            "Resembles digital computer",
                            "Resembles analogue computer",
                            "Resembles both a digital and analogue computer",
                            "None of the above"
                        ],
                        Answer = "Resembles both a digital and analogue computer"
                    },
                    new()
                    {
                        StrQuestion = "Which type of computers uses the 8-bit code called EBCDIC?",
                        Options = ["Minicomputers", "Microcomputers", "Mainframe computers", "Super computer"],
                        Answer = "Mainframe computers"
                    },
                    new()
                    {
                        StrQuestion = "The ALU of a computer responds to the commands coming from",
                        Options = ["Primary memory", "Control section", "External memory", "Cache memory"],
                        Answer = "Control section"
                    },
                    new()
                    {
                        StrQuestion = "Chief component of first generation computer was",
                        Options = ["Transistors", "Vacuum Tubes and Valves", "Integrated Circuits", "None of above"],
                        Answer = "Vacuum Tubes and Valves"
                    },
                    new()
                    {
                        StrQuestion = "To produce high quality graphics (hardcopy) in color, you would want to use a/n",
                        Options = ["RGB monitor", "Plotter", "Ink-jet printer", "Laser printer"],
                        Answer = "Plotter"
                    },


                ]
            },

            new ("CSC101")
            {
                QuestionsList =
                [
                     new()
                    {
                        StrQuestion = "What are the stages in the compilation process?",
                        Options = [
                            "Feasibility study, system design and testing",
                            "Implementation and documentation",
                            "Lexical Analysis, syntax analysis, and code generation",
                            "None of the above"
                        ],
                        Answer = "Lexical Analysis, syntax analysis, and code generation"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following IC was used in third generation of computers?",
                        Options = ["SSI", "MSI", "LSI", "Both a and b"],
                        Answer = "Both a and b"
                    },
                    new()
                    {
                        StrQuestion = "A characteristic of card systems is:",
                        Options = ["Slowness in processing data", "Using cards as records of transactions", "Needing a larger DP staff", "All of the above"],
                        Answer = "All of the above",
                    },

                    new()
                    {
                        StrQuestion = "The full form of EEPROM is",
                        Options = ["Electrically Erasable Programmable Read Only Memory", "Easily Erasable Programmable Read Only Memory", "Electronic Erasable Programmable Read Only Memory", "None of the above"],
                        Answer = "Electrically Erasable Programmable Read Only Memory",
                    },

                    new()
                    {
                        StrQuestion = "The original ASCII code used__bits of each byte, reserving that last bit for error checking",
                        Options = ["5", "6", "7", "8"],
                        Answer = "7",
                    },

                    new()
                    {
                        StrQuestion = "A computer programmer",
                        Options = ["Does all the thinking for a computer", "Can enter input data quickly", "Can operate all types of computer equipments", "Can draw only flowchart"],
                        Answer = "Does all the thinking for a computer",
                    },

                    new()
                    {
                        StrQuestion = "Fifth generation computer is also known as",
                        Options = ["Knowledge information processing system", "Very large scale integration (VLSI)", "Both of above", "None of above"],
                        Answer = "Both of above",
                    },

                    new()
                    {
                        StrQuestion = "The commonly used standard data code to represent alphabetical, numerical and punctuation characters used in electronic data processing system is called",
                        Options = ["ASCII", "EBCDIC", "BCD", "All of above"],
                        Answer = "ASCII",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following have low failure rate?",
                        Options = ["Mechanical devices", "Electronic devices", "Electro-mechanical devices", "None of above"],
                        Answer = "Electronic devices",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following memories need refresh?",
                        Options = ["SRAM", "DRAM", "ROM", "All of the above"],
                        Answer = "DRAM",
                    },

                    new()
                    {
                        StrQuestion = "A typical personal computer used for business purposes would have__ of RAM.",
                        Options = ["4 KB", "16 K", "64 K", "256 K"],
                        Answer = "64 K",
                    },

                    new()
                    {
                        StrQuestion = "The ALU of a computer normally contains a number of high speed storage elements called",
                        Options = ["Semiconductor memory", "Registers", "Hard disks", "Magnetic dis"],
                        Answer = "Registers",
                    },
                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "The main electronic component used in first generation computers was",
                        Options = ["Transistors", "Vacuum Tubes and Valves", "Integrated Circuits", "None of above"],
                        Answer = "Vacuum Tubes and Valves"
                    },
                    new()
                    {
                        StrQuestion = "A dumb terminal has",
                        Options = ["an embedded microprocessor", "extensive memory", "independent processing capability", "a keyboard and screen"],
                        Answer = "a keyboard and screen"
                    },
                    new()
                    {
                        StrQuestion = "One millisecond is",
                        Options = ["1 second", "10th of a seconds", "1000th of a seconds", "10000th of a seconds"],
                        Answer = "1000th of a seconds"
                    },
                    new()
                    {
                        StrQuestion = "The output quality of a printer is measured by",
                        Options = ["Dot per sq. inch", "Dot per inch", "Dots printed per unit time", "All of the above"],
                        Answer = "Dot per inch"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following was a special purpose computer?",
                        Options = ["ABC", "ENIAC", "EDVAC", "All of the above"],
                        Answer = "ABC"
                    },
                    new()
                    {
                        StrQuestion = "What was the computer invented by Attanasoff and Clifford?",
                        Options = ["Mark I", "ABC", "Z3", "None of above"],
                        Answer = "ABC"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following storage devices can store maximum amount of data?",
                        Options = ["Floppy Disk", "Hard Disk", "Compact Disk", "Magneto Optic Disk"],
                        Answer = "Hard Disk"
                    },
                    new()
                    {
                        StrQuestion = "Which computer was considered the first electronic computer until 1973 when court invalidated the patent?",
                        Options = ["ENIAC", "MARK I", "Z3", "ABC"],
                        Answer = "ENIAC"
                    },
                    new()
                    {
                        StrQuestion = "A physical connection between the microprocessor memory and other parts of the microcomputer is known as",
                        Options = ["Path", "Address bus", "Route", "All of the above"],
                        Answer = "Address bus"
                    },
                    new()
                    {
                        StrQuestion = "High density double sided floppy disks could store _____ of data",
                        Options = ["1.40 MB", "1.44 GB", "1.40 GB", "1.44 MB"],
                        Answer = "1.44 MB"
                    },
                    new()
                    {
                        StrQuestion = "Which was the computer conceived by Babbage?",
                        Options = ["Analytical Engine", "Arithmetic Machine", "Donald Kunth", "All of above"],
                        Answer = "Analytical Engine",
                    },

                    new()
                    {
                        StrQuestion = "The processing speed of first generation computers was",
                        Options = ["milliseconds", "microseconds", "nanoseconds", "picoseconds"],
                        Answer = "milliseconds",
                    },

                    new()
                    {
                        StrQuestion = "Model 5100 was ______ in 1957.",
                        Options = ["The first PC built by IBM", "The first PC built by Apple", "The first PC built by Motorola", "The first PC built by Intel"],
                        Answer = "The first PC built by IBM",
                    },

                    new()
                    {
                        StrQuestion = "VGA is",
                        Options = ["Video Graphics Array", "Visual Graphics Array", "Volatile Graphics Array", "Video Graphics Adapter"],
                        Answer = "Video Graphics Array",
                    },

                    new()
                    {
                        StrQuestion = "A kind of scanner MICR is the short form of",
                        Options = ["Magnetic Ink Character Reader", "Magnetic Ink Code Reader", "Magnetic Ink Cases Reader", "None"],
                        Answer = "Magnetic Ink Character Reader",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not a class based on size?",
                        Options = ["Mainframe Computer", "Micro Computer", "Mini Computer", "Digital Computer"],
                        Answer = "Digital Computer",
                    },

                    new()
                    {
                        StrQuestion = "Which 8-bit chip was used in many of today’s TRS-80 computers?",
                        Options = ["Z-8000", "Motorola 6809", "Z-8808", "Z-80"],
                        Answer = "Z-80",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following disk is fixed disk?",
                        Options = ["Hard Disks", "Flash Disks", "Blu-Ray Disks", "DVDs"],
                        Answer = "Hard Disks",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following professions has not been affected by personal computers?",
                        Options = ["Medical", "Clerical and law", "Accounting", "None of the above"],
                        Answer = "None of the above",
                    },

                    new()
                    {
                        StrQuestion = "The word Abacus is derived from Abax, a word from",
                        Options = ["Latin language", "Greek Language", "Sanskrit language", "Ancient Egypt"],
                        Answer = "Greek Language",
                    },

                    new()
                    {
                        StrQuestion = "In latest generation computers, the instructions are executed",
                        Options = ["Parallel only", "Sequentially only", "Both sequentially and parallel", "All of above"],
                        Answer = "Both sequentially and parallel",
                    },



                ]
            },

            new ("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which of the following memory medium is not used as main memory system?",
                        Options = ["Magnetic core", "Semiconductor", "Magnetic tape", "Both a and b"],
                        Answer = "Magnetic tape",
                    },

                    new()
                    {
                        StrQuestion = "An online backing storage system capable of storing larger quantities of data is",
                        Options = ["CPU", "Memory", "Mass storage", "Secondary storage"],
                        Answer = "Mass storage",
                    },

                    new()
                    {
                        StrQuestion = "A kind of serial dot-matrix printer that forms characters with magnetically-charged ink sprayed dots is called",
                        Options = ["Laser printer", "Ink-jet printer", "Drum printer", "Chan printer"],
                        Answer = "Ink-jet printer",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following does not affect the resolution of a video display image?",
                        Options = ["Bandwidth", "Raster scan range", "Vertical and horizontal lines of resolution", "Screen size"],
                        Answer = "Bandwidth",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following printing devices an output composed of a series of data?",
                        Options = ["Wire matrix printer", "Band printer", "Wang image printer", "Both a and c"],
                        Answer = "Both a and c",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is an example of fifth generation computer?",
                        Options = ["PIM/m", "ICL 2950", "IBM 1401", "None of above"],
                        Answer = "None of above",
                    },

                    new()
                    {
                        StrQuestion = "Magnetic disks are the most popular medium for",
                        Options = ["Direct access", "Sequential access", "Both of above", "None of above"],
                        Answer = "Direct access",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not a third generation computer?",
                        Options = ["IBM 360", "IBM 1401", "PDP-8", "HP2115"],
                        Answer = "HP2115",
                    },

                    new()
                    {
                        StrQuestion = "The number of records contained within a block of data on magnetic tape is defined by the",
                        Options = ["Block definition", "Record contain clause", "Blocking factor", "Record per block"],
                        Answer = "Blocking factor",
                    },

                    new()
                    {
                        StrQuestion = "Mark I is also known as",
                        Options = ["American Sequence Controlled Calculator", "Automatic Sequence Calculating Controller", "American Sequence Controlled Computer", "Automatic Sequence Controlled Calculator"],
                        Answer = "Automatic Sequence Controlled Calculator",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following registers is loaded with the contents of the memory location pointed by the PC?",
                        Options = ["Memory address registers", "Memory data registers", "Instruction register", "Program counter"],
                        Answer = "Memory address registers",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following are the cheapest memory devices in terms of Cost/Bit?",
                        Options = ["Semiconductor memories", "Magnetic Disks", "Compact Disks", "Magnetic Tapes"],
                        Answer = "Magnetic Tapes",
                    },

                    new()
                    {
                        StrQuestion = "MIS is designed to provide information needed for effective decision making by?",
                        Options = ["Consumers", "Workers", "Foremen", "Managers"],
                        Answer = "Managers",
                    },

                    new()
                    {
                        StrQuestion = "Which is valid statement?",
                        Options = ["1 KB = 1 024 Bytes", "1 MB = 1 024 Bytes", "1 KB = 1 000 Bytes", "1 MB = 1 000 Bytes"],
                        Answer = "1 KB = 1 024 Bytes",
                    },

                    new()
                    {
                        StrQuestion = "Latency time is",
                        Options = ["Time to spin the needed data under head", "Time to spin the needed data under track", "Time to spin data under sector", "All of above"],
                        Answer = "All of above",
                    },

                    new()
                    {
                        StrQuestion = "Who built the first Mechanical Calculator?",
                        Options = ["Joseph Marie Jacquard", "John Mauchly", "Blaise Pascal", "Howard Aiken"],
                        Answer = "Blaise Pascal",
                    },

                    new()
                    {
                        StrQuestion = "The most important advantage of a video disk is",
                        Options = ["Compactness", "Potential capacity", "Durability", "Cost effectiveness"],
                        Answer = "Potential capacity",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following generation computers had expensive operation cost?",
                        Options = ["First", "Second", "Third", "Fourth"],
                        Answer = "First",
                    },

                    new()
                    {
                        StrQuestion = "An IBM system/38 represents the computer class of:",
                        Options = ["Small-scale computer", "Medium-scale computer", "Large-scale computer", "Super computer"],
                        Answer = "Medium-scale computer",
                    },

                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "A high quality CAD system uses the following for printing drawing and graphs",
                        Options = ["Dot matrix printer", "Digital plotter", "Line printer", "All of the above"],
                        Answer = "Digital plotter"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is not an input device?",
                        Options = ["OCR", "Optical scanners", "Voice recognition device", "COM (Computer Output to Microfilm)"],
                        Answer = "COM (Computer Output to Microfilm)"
                    },
                    new()
                    {
                        StrQuestion = "The accuracy of the floating-point numbers representable in two 16-bit words of a computer is approximately",
                        Options = ["16 digits", "6 digits", "9 digits", "All of above"],
                        Answer = "6 digits"
                    },
                    new()
                    {
                        StrQuestion = "In most of the IBM PCs, the CPU, the device drivers, memory, expansion slots and active components are mounted on a single board. What is the name of the board?",
                        Options = ["Motherboard", "Daughterboard", "Bredboard", "Fatherboard"],
                        Answer = "Motherboard"
                    },
                    new()
                    {
                        StrQuestion = "In most IBM PCs, the CPU, the device drives, memory expansion slots and active components are mounted on a single board. What is the name of this board?",
                        Options = ["Motherboard", "Breadboard", "Daughter board", "Grandmother board"],
                        Answer = "Motherboard"
                    },
                    new()
                    {
                        StrQuestion = "Magnetic disks are the most popular medium for",
                        Options = ["Direct access", "Sequential access", "Both of above", "None of above"],
                        Answer = "Direct access"
                    },
                    new()
                    {
                        StrQuestion = "A technique used by codes to convert an analog signal into a digital bit stream is known as",
                        Options = ["Pulse code modulation", "Pulse stretcher", "Query processing", "Queue management"],
                        Answer = "Pulse code modulation"
                    },
                    new()
                    {
                        StrQuestion = "Regarding a VDU, Which statement is more correct?",
                        Options = ["It is an output device", "It is an input device", "It is a peripheral device", "It is hardware item"],
                        Answer = "It is an output device"
                    },
                    new()
                    {
                        StrQuestion = "A modern electronic computer is a machine that is meant for",
                        Options = [
                            "Doing quick mathematical calculations",
                            "Input, storage, manipulation and outputting of data",
                            "Electronic data processing",
                            "Performing repetitive tasks accurately"
                        ],
                        Answer = "Input, storage, manipulation and outputting of data"
                    },
                    new()
                    {
                        StrQuestion = "When was vacuum tube invented?",
                        Options = ["1900", "1906", "1910", "1880"],
                        Answer = "1906"
                    },
                    new()
                    {
                        StrQuestion = "Another word for a daisy wheel printer",
                        Options = ["Petal printer", "Golf ball printer", "Laser printer", "Line printer"],
                        Answer = "Golf ball printer",
                    },

                    new()
                    {
                        StrQuestion = "Cursor is a ____",
                        Options = ["Pixel", "Thin blinking line", "Pointing device", "None of these"],
                        Answer = "Thin blinking line",
                    },

                    new()
                    {
                        StrQuestion = "Which device is used to backup the data?",
                        Options = ["Floppy Disk", "Tape", "Network Drive", "All of the above"],
                        Answer = "All of the above",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following printers are you sure will not to use if your objective is to print on multi carbon forms?",
                        Options = ["Daisy wheel", "Dot matrix", "Laser", "Thimble"],
                        Answer = "Laser",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following items are examples of storage devices?",
                        Options = ["Floppy / hard disks", "CD-ROMs", "Tape devices", "All of the above"],
                        Answer = "All of the above",
                    },

                    new()
                    {
                        StrQuestion = "ASCII and EBCDIC are the popular character coding systems. What does ASCII stand for?",
                        Options = ["American Stable Code for International Interchange", "American Standard Case for Institutional Interchange", "American Standard Code for Information Interchange", "American Standard Code for Interchange Information"],
                        Answer = "American Standard Code for Information Interchange",
                    },

                    new()
                    {
                        StrQuestion = "Which computers are used as servers for any medium sized organizations?",
                        Options = ["Mainframe Computer", "Mini Computers", "Micro Computers", "Super Computers"],
                        Answer = "Mini Computers",
                    },

                    new()
                    {
                        StrQuestion = "Slide Rules was invented in",
                        Options = ["1614", "1617", "1620", "None of above"],
                        Answer = "1620",
                    },

                    new()
                    {
                        StrQuestion = "A normal CD-ROM usually can store up to __________data?",
                        Options = ["680 KB", "680 Bytes", "680 MB", "680 GB"],
                        Answer = "680 MB",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following required large computer memory?",
                        Options = ["Imaging", "Graphics", "Voice", "All of above"],
                        Answer = "All of above",
                    },

                    new()
                    {
                        StrQuestion = "Which was the computer conceived by Babbage?",
                        Options = ["Analytical engine", "Arithmetic machine", "Donald Knuth", "All of above"],
                        Answer = "Analytical engine",
                    },


                ]
            },

            new ("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "The lower deck of an abacus is known as",
                        Options = ["heaven", "sky", "earth", "floor"],
                        Answer = "earth",
                    },

                    new()
                    {
                        StrQuestion = "All modern computers operate on",
                        Options = ["Information", "Floppies", "Data", "Word"],
                        Answer = "Data",
                    },

                    new()
                    {
                        StrQuestion = "The computer that can input analog signals and return result in digital form",
                        Options = ["Analog Computers", "Digital Computers", "Hybrid Computers", "Mainframe Computers"],
                        Answer = "Hybrid Computers",
                    },

                    new()
                    {
                        StrQuestion = "Offline device is",
                        Options = ["A device which is not connected to CPU", "A device which is connected to CPU", "A direct access storage device", "An I/O device"],
                        Answer = "A device which is not connected to CPU",
                    },

                    new()
                    {
                        StrQuestion = "What is the latest write-once optical storage media?",
                        Options = ["Digital paper", "Magneto-optical disk", "WORM disk", "CD-ROM disk"],
                        Answer = "WORM disk",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following programming language started from second generation?",
                        Options = ["LISP", "C", "QBASIC", "FORTRAN"],
                        Answer = "FORTRAN",
                    },

                    new()
                    {
                        StrQuestion = "Which one of the following input device is user-programmable?",
                        Options = ["Dumb terminal", "Smart terminal", "VDT", "Intelligent terminal"],
                        Answer = "Intelligent terminal",
                    },

                    new()
                    {
                        StrQuestion = "Floppy disks typically in diameter",
                        Options = ["3\"", "5.25\"", "8\"", "All of above"],
                        Answer = "All of above",
                    },

                    new()
                    {
                        StrQuestion = "Current SIMMs have either __ or __ connectors (pins)",
                        Options = ["9 or 32", "30 or 70", "28 or 72", "30 or 72"],
                        Answer = "30 or 72",
                    },

                    new()
                    {
                        StrQuestion = "Dot-matrix is a type of",
                        Options = ["Tape", "Printer", "Disk", "Bus"],
                        Answer = "Printer",
                    },

                    new()
                    {
                        StrQuestion = "Which is not consisted in a processor",
                        Options = ["ALU", "CU", "Memory", "Registers"],
                        Answer = "Memory",
                    },

                    new()
                    {
                        StrQuestion = "IBM 1401 is the first computer to enter in Nepal. It belonged to",
                        Options = ["First Generation", "Second Generation", "Third Generation", "Fourth Generation"],
                        Answer = "Second Generation",
                    },

                    new()
                    {
                        StrQuestion = "The Third Generation Computer was made with ________.",
                        Options = ["Vacuum Tube", "Discrete Components", "IC", "Bio Chips"],
                        Answer = "IC",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following are the two main components of the CPU?",
                        Options = ["Control Unit and Registers", "Registers and Main Memory", "Control unit and ALU", "ALU and bus"],
                        Answer = "Control unit and ALU",
                    },

                    new()
                    {
                        StrQuestion = "Fifth generation computer is also known as",
                        Options = ["Knowledge information processing system", "Very large scale integration", "Both of above", "None of above"],
                        Answer = "Both of above",
                    },

                    new()
                    {
                        StrQuestion = "Second Generation computers were developed during",
                        Options = ["1949 to 1955", "1956 to 1965", "1965 to 1970", "1970 to 1990"],
                        Answer = "1956 to 1965",
                    },

                    new()
                    {
                        StrQuestion = "What is the name of the computer terminal which gives paper printout?",
                        Options = ["Display screen", "Soft copy terminal", "Hard copy terminal", "Plotter"],
                        Answer = "Hard copy terminal",
                    },

                    new()
                    {
                        StrQuestion = "Programs are executed on the basis of a priority number in a",
                        Options = ["Batch processing system", "Multiprogramming", "Time sharing", "None of these"],
                        Answer = "Batch processing system",
                    },


                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which of the following produces the best quality graphics reproduction?",
                        Options = ["Laser printer", "Ink jet printer", "Plotter", "Dot matrix printer"],
                        Answer = "Plotter"
                    },
                    new()
                    {
                        StrQuestion = "Computers with 80286 microprocessor is",
                        Options = ["XT computer", "AT computers", "PS/2 computer", "None of above"],
                        Answer = "AT computers"
                    },
                    new()
                    {
                        StrQuestion = "An application suitable for sequential processing is",
                        Options = ["Processing of grades", "Payroll processing", "Both a and b", "All of above"],
                        Answer = "Both a and b"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is not processing?",
                        Options = ["arranging", "manipulating", "calculating", "gathering"],
                        Answer = "gathering"
                    },
                    new()
                    {
                        StrQuestion = "The digital computer was developed primarily in",
                        Options = ["USSR", "Japan", "USA", "UK"],
                        Answer = "USA"
                    },
                    new()
                    {
                        StrQuestion = "Software in computer",
                        Options = [
                            "Enhances the capabilities of the hardware machine",
                            "Increase the speed of central processing unit",
                            "Both of above",
                            "None of above"
                        ],
                        Answer = "Enhances the capabilities of the hardware machine"
                    },
                    new()
                    {
                        StrQuestion = "Today’s computer giant IBM was earlier known by different name which was changes in 1924. What was that name?",
                        Options = [
                            "Tabulator Machine Co.",
                            "Computing Tabulating Recording Co.",
                            "The Tabulator Ltd.",
                            "International Computer Ltd."
                        ],
                        Answer = "Computing Tabulating Recording Co."
                    },
                    new()
                    {
                        StrQuestion = "Before a disk drive can access any sector record, a computer program has to provide the record’s disk address. What information does this address specify?",
                        Options = ["Track number", "Sector number", "Surface number", "All of above"],
                        Answer = "All of above"
                    },
                    new()
                    {
                        StrQuestion = "The arranging of data in a logical sequence is called",
                        Options = ["Sorting", "Classifying", "Reproducing", "Summarizing"],
                        Answer = "Sorting"
                    },
                    new()
                    {
                        StrQuestion = "What is the responsibility of the logical unit in the CPU of a computer?",
                        Options = [
                            "To produce result",
                            "To compare numbers",
                            "To control flow of information",
                            "To do math’s works"
                        ],
                        Answer = "To compare numbers"
                    },
                    new()
                    {
                        StrQuestion = "When was Apple Macintosh II microcomputer introduced in the market?",
                        Options = ["1964", "1970", "1983", "1986"],
                        Answer = "1983",
                    },

                    new()
                    {
                        StrQuestion = "When was the world’s first laptop computer introduced in the market and by whom?",
                        Options = ["Hewlett-Packard", "Epson, 1981", "Laplink traveling software In 1982", "Tandy model-2000, 1985"],
                        Answer = "Epson, 1981",
                    },

                    new()
                    {
                        StrQuestion = "Today’s computer giant IBM was earlier known by different name which was changed in 1924. What was that name?",
                        Options = ["Computer Tabulating Recording Co.", "The Tabulator Ltd.", "International Computer Ltd.", "None of above"],
                        Answer = "Computer Tabulating Recording Co.",
                    },

                    new()
                    {
                        StrQuestion = "The personnel who deals with the computer and its management put together are called",
                        Options = ["Software", "Human ware", "Firmware", "Hardware"],
                        Answer = "Human ware",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is input device?",
                        Options = ["Scanner", "Speaker", "Monitor", "Projector"],
                        Answer = "Scanner",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is true?",
                        Options = ["Fields are composed of bytes", "Records are composed of fields", "Fields are composed of characters", "All of above"],
                        Answer = "All of above",
                    },

                    new()
                    {
                        StrQuestion = "Who built the world’s first electronic calculator using telephone relays, light bulbs and batteries?",
                        Options = ["Claude Shannon", "Konrard Zues", "George Stibits", "Howard H. Aiken"],
                        Answer = "George Stibits",
                    },

                    new()
                    {
                        StrQuestion = "WAN is a most used abbreviation in Networking, what is its full form?",
                        Options = ["WAP Area Network", "Wide Area Network", "Wide Array of Network", "Wireless Access Network"],
                        Answer = "Wide Area Network",
                    },

                    new()
                    {
                        StrQuestion = "In which language is source program written?",
                        Options = ["English", "Symbolic", "High level", "Temporary"],
                        Answer = "High level",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is correct acronym of VGA?",
                        Options = ["Video Graphics Array", "Visual Graphics Array", "Volatile Graphics Array", "Video Graphics Adapter"],
                        Answer = "Video Graphics Array",
                    },

                    new()
                    {
                        StrQuestion = "A song being played on computer speaker is",
                        Options = ["Hard output", "Soft output", "Both hard and soft output", "Neither hard nor soft output"],
                        Answer = "Soft output",
                    },

                    new()
                    {
                        StrQuestion = "In the IBM PC-At, what do the words AT stand for?",
                        Options = ["Additional Terminals", "Advance technology", "Applied technology", "Advanced terminology"],
                        Answer = "Advanced technology",
                    },

                    new()
                    {
                        StrQuestion = "Size of the primary memory of a PC ranges between",
                        Options = ["2KB to 8KB", "64KB & 256KB", "256KB & 640KB", "None of these"],
                        Answer = "256KB & 640KB",
                    },

                    new()
                    {
                        StrQuestion = "What is the number of read-write heads in the drive for a 9-track magnetic tape?",
                        Options = ["9", "16", "18", "27"],
                        Answer = "18",
                    },

                    new()
                    {
                        StrQuestion = "Apple company used chips from ______ for its computers",
                        Options = ["Intel", "Motorola", "Both of above", "None of above"],
                        Answer = "Motorola",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is a feature of fifth generation computers?",
                        Options = ["Use of natural language", "Artificial intelligence", "Bio-chips", "All of above"],
                        Answer = "All of above",
                    },

                    new()
                    {
                        StrQuestion = "Charles Babbage was awarded by Royal Society for his",
                        Options = ["Difference Engine", "Analytic Engine", "Binary System in Analytic Engine", "His concept of input, mill, output and storage"],
                        Answer = "Difference Engine",
                    },

                    new()
                    {
                        StrQuestion = "A computer which CPU speed around 100 million instruction per second and with the word length of around 64 bits is known as",
                        Options = ["Super computer", "Mini computer", "Micro computer", "Macro computer"],
                        Answer = "Super computer",
                    },

                    new()
                    {
                        StrQuestion = "When we look at the cost, which of the following computer is most expensive?",
                        Options = ["Mainframe Computer", "Mini Computers", "Micro Computers", "Super Computers"],
                        Answer = "Super Computers",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following will happen when data is entered into a memory location?",
                        Options = ["It will add to the content of the location", "It will change the address of the memory location", "It will erase the previous content", "It will not be fruitful if there is already some data at the location"],
                        Answer = "It will erase the previous content",
                    },

                    new()
                    {
                        StrQuestion = "Which device is used as the standard pointing device in a Graphical User Environment?",
                        Options = ["Keyboard", "Mouse", "Joystick", "Track ball"],
                        Answer = "Mouse",
                    },

                    new()
                    {
                        StrQuestion = "Mini computers and micro computers are from which generation of computers?",
                        Options = ["First", "Second", "Third", "Fourth"],
                        Answer = "Second",
                    },

                    new()
                    {
                        StrQuestion = "Pick the one that is used for logical operations or comparisons such as less than equal to or greater than.",
                        Options = ["Arithmetic and Logic Unit", "Control Unit", "Both of above", "None of above"],
                        Answer = "Arithmetic and Logic Unit",
                    },

                    new()
                    {
                        StrQuestion = "The operating speed of third generation computer was",
                        Options = ["Milliseconds", "Microseconds", "Nanoseconds", "Picoseconds"],
                        Answer = "Nanoseconds",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is true?",
                        Options = ["Mark I was 8 feet long", "Mark I was 2 feet long", "Mark I was 40 feet long", "None of above"],
                        Answer = "Mark I was 40 feet long",
                    },

                    new()
                    {
                        StrQuestion = "Charles Babbage is considered the father of modern computers because",
                        Options = ["of his difference engine", "of his analytical engine", "his concept of input, mill and output", "All of above"],
                        Answer = "All of above",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is used only for data entry and storage, and never for processing?",
                        Options = ["Mouse", "Dumb terminal", "Micro computer", "Dedicated data entry system"],
                        Answer = "Dumb terminal",
                    },

                    new()
                    {
                        StrQuestion = "What was the first computer brought in Nepal?",
                        Options = ["ICL/2950", "ENIAC", "IBM 1401", "None of above"],
                        Answer = "IBM 1401",
                    },

                    new()
                    {
                        StrQuestion = "The primary advantage of key-to-tape data entry system is",
                        Options = ["A large percentage of editing can be performed at the time of data entry", "Key verification is easily performed", "The tape is reusable", "Keying errors can be detected as they occur."],
                        Answer = "Keying errors can be detected as they occur.",
                    },

                    new()
                    {
                        StrQuestion = "Basic is ________ language.",
                        Options = ["a procedural", "an object oriented", "both A and B", "none of the above"],
                        Answer = "a procedural",
                    },

                    new()
                    {
                        StrQuestion = "A computer Program that translates one program instruction at a time into machine language is called a/an",
                        Options = ["Interpreter", "CPU", "Compiler", "Simulator"],
                        Answer = "Interpreter",
                    },

                ]
            },
            new("CSC101")
            {
                QuestionsList =
                [

                    new()
                    {
                        StrQuestion = "The first computer introduced in Nepal was",
                        Options = ["IBM 1400", "IBM 1401", "IBM 1402", "IBM 1402"],
                        Answer = "IBM 1401"
                    },
                    new()
                    {
                        StrQuestion = "Mnemonic a memory trick is used in which of the following language?",
                        Options = ["Machine language", "Assembly language", "High level language", "None of above"],
                        Answer = "Assembly language"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following have the fastest access time?",
                        Options = ["Semiconductor Memories", "Magnetic Disks", "Magnetic Tapes", "Compact Disks"],
                        Answer = "Semiconductor Memories",
                    },

                    new()
                    {
                        StrQuestion = "The first electronic general purpose digital computer built by Eckert and Mauchly called ENIAC did not work on the stored program concept. How many numbers could it store in its internal memory?",
                        Options = ["100", "20", "40", "80"],
                        Answer = "20",
                    },

                    new()
                    {
                        StrQuestion = "The computer that processes both analog and digital is called",
                        Options = ["Analog computer", "Digital computer", "Hybrid computer", "Mainframe computer"],
                        Answer = "Hybrid computer",
                    },

                    new()
                    {
                        StrQuestion = "What was the name of the first commercially available microprocessor chip?",
                        Options = ["Intel 308", "Intel 33", "Intel 4004", "Motorola 639"],
                        Answer = "Intel 4004",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following class of computers can process physical quantities such as speed?",
                        Options = ["Analog Computers", "Digital Computers", "Hybrid Computers", "None of above"],
                        Answer = "Analog Computers",
                    },

                    new()
                    {
                        StrQuestion = "How many types of storage loops exist in magnetic bubble memory?",
                        Options = ["8", "4", "16", "2"],
                        Answer = "4",
                    },

                    new()
                    {
                        StrQuestion = "When did IBM introduce the 20286 based PC/AT?",
                        Options = ["1982", "1984", "1985", "1989"],
                        Answer = "1984",
                    },

                    new()
                    {
                        StrQuestion = "The silicon chips used for data processing are called",
                        Options = ["RAM chips", "ROM chips", "Micro processors", "PROM chips"],
                        Answer = "Micro processors",
                    },

                    new()
                    {
                        StrQuestion = "Which computers used operating systems by Microsoft?",
                        Options = ["IBM PCs", "Apple/Macintosh PCs", "IBM Compatibles", "Both A & C"],
                        Answer = "Both A & C",
                    },

                    new()
                    {
                        StrQuestion = "One of the main features that distinguish microprocessors from micro-computers is",
                        Options = ["Words are usually large in microprocessors", "Words are shorter in microprocessors", "Microprocessor does not contain I/O device", "Exactly the same as the machine cycle time"],
                        Answer = "Microprocessor does not contain I/O device",
                    },

                    new()
                    {
                        StrQuestion = "Napier’s Bones were invented in",
                        Options = ["1614", "1617", "1620", "None of above"],
                        Answer = "1617",
                    },

                    new()
                    {
                        StrQuestion = "One computer that is not considered a portable computer is",
                        Options = ["Minicomputer", "A laptop computer", "Tablet PC", "All of the above"],
                        Answer = "Minicomputer",
                    },

                    new()
                    {
                        StrQuestion = "Computers built before the First Generation of computers were:",
                        Options = ["Mechanical", "Electro-mechanical", "Electrical", "None of these"],
                        Answer = "Electro-mechanical",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is a way to access secondary memory?",
                        Options = ["Random access memory", "Action method", "Transfer method", "Density method"],
                        Answer = "Transfer method",
                    },

                    new()
                    {
                        StrQuestion = "What is System Analysis?",
                        Options = ["The design of the screen the user will see and use to enter or display data", "System analysis defines the format and type of data the program will use", "System Analysis involves creating formal model of the problem to be solved", "None of the above"],
                        Answer = "System Analysis involves creating formal model of the problem to be solved",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following devices have a limitation that we can only store information to it but cannot erase or modify it?",
                        Options = ["Floppy Disk", "Hard Disk", "Tape Drive", "CDROM"],
                        Answer = "CDROM",
                    },

                    new()
                    {
                        StrQuestion = "Which is an item of storage medium in the form of circular plate?",
                        Options = ["Disk", "CPU", "Printer", "ALU"],
                        Answer = "Disk",
                    },

                    new()
                    {
                        StrQuestion = "Daisy wheel printer is a type of",
                        Options = ["Matrix printer", "Impact printer", "Laser printer", "Manual printer"],
                        Answer = "Impact printer",
                    },

                    new()
                    {
                        StrQuestion = "A number system that has eight different symbols to represent any quantity is known as",
                        Options = ["Binary", "Octal", "Decimal", "Hexadecimal"],
                        Answer = "Octal",
                    },

                    new()
                    {
                        StrQuestion = "The two basic types of record access methods are:",
                        Options = ["Sequential and random", "Sequential and indexed", "Direct and immediate", "Online and real time"],
                        Answer = "Sequential and random",
                    },

                    new()
                    {
                        StrQuestion = "Artificial Intelligence is associated with which generation?",
                        Options = ["First Generation", "Second Generation", "Fifth Generation", "Sixth Generation"],
                        Answer = "Fifth Generation",
                    },

                    new()
                    {
                        StrQuestion = "One of a class of storage device that can access storage locations in any order is",
                        Options = ["DTE", "DASD", "DDE", "DDE"],
                        Answer = "DASD",
                    },

                    new()
                    {
                        StrQuestion = "The actual execution of instructions happens in",
                        Options = ["ALU", "CU", "Memory", "None of above"],
                        Answer = "ALU",
                    },

                    new()
                    {
                        StrQuestion = "Floppy disks are available in",
                        Options = ["Single side single density", "Single side double density", "Both of above", "None of above"],
                        Answer = "Both of above",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not an electro-mechanical computer?",
                        Options = ["Z3", "ABC", "Mark I", "ENIAC"],
                        Answer = "ENIAC",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is a programming language?",
                        Options = ["Lotus", "Pascal", "MS-Excel", "Netscape"],
                        Answer = "Pascal",
                    },

                    new()
                    {
                        StrQuestion = "Which converts the user data into machine readable form?",
                        Options = ["Input unit, output unit, control unit", "Central processing unit", "Output unit", "Decoder unit"],
                        Answer = "Decoder unit",
                    },

                    new()
                    {
                        StrQuestion = "In what respect human beings are superior to computers?",
                        Options = ["Diligence", "Intelligence", "Slavery", "Reliability"],
                        Answer = "Intelligence",
                    },

                    new()
                    {
                        StrQuestion = "As compared to the secondary memory, the primary memory of a computer is",
                        Options = ["Large", "Cheap", "Fast", "Slow"],
                        Answer = "Fast",
                    },

                    new()
                    {
                        StrQuestion = "The language that the computer can understand and execute is called",
                        Options = ["Machine language", "Application software", "System program", "All of above"],
                        Answer = "Machine language",
                    },

                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Instruction in computer languages consists of",
                        Options = ["OPCODE", "OPERAND", "Both of above", "None of above"],
                        Answer = "Both of above"
                    },
                    new()
                    {
                        StrQuestion = "Which generation of computer is still under development",
                        Options = ["Fourth Generation", "Fifth Generation", "Sixth Generation", "Seventh Generation"],
                        Answer = "Fifth Generation"
                    },
                    new()
                    {
                        StrQuestion = "A register organized to allow to move left or right operations is called a ____",
                        Options = ["Counter", "Loader", "Adder", "Shift register"],
                        Answer = "Shift register"
                    },
                    new()
                    {
                        StrQuestion = "Which was the most popular first generation computer?",
                        Options = ["IBM 1650", "IBM 360", "IBM 1130", "IBM 2700"],
                        Answer = "IBM 1650"
                    },
                    new()
                    {
                        StrQuestion = "Which is considered a direct entry input device?",
                        Options = ["Optical scanner", "Mouse and digitizer", "Light pen", "All of the above"],
                        Answer = "All of the above"
                    },
                    new()
                    {
                        StrQuestion = "A set of information that defines the status of resources allocated to a process is",
                        Options = ["Process control", "ALU", "Register Unit", "Process description"],
                        Answer = "Process description"
                    },
                    new()
                    {
                        StrQuestion = "Each set of Napier’s bones consisted of ______ rods.",
                        Options = ["5", "9", "11", "13"],
                        Answer = "11"
                    },
                    new()
                    {
                        StrQuestion = "BCD is",
                        Options = ["Binary Coded Decimal", "Bit Coded Decimal", "Binary Coded Digit", "Bit Coded Digit"],
                        Answer = "Binary Coded Decimal"
                    },
                    new()
                    {
                        StrQuestion = "When was the world’s first laptop computer introduced in the market and by whom?",
                        Options = [
                            "Hewlett-Packard, 1980",
                            "Epson, 1981",
                            "Laplink Traveling Software Inc, 1982",
                            "Tandy Model-200, 1985"
                        ],
                        Answer = "Epson, 1981"
                    },
                    new()
                    {
                        StrQuestion = "From which generation operating systems were developed?",
                        Options = ["First", "Second", "Third", "Fourth"],
                        Answer = "Third"
                    },
                    new()
                    {
                        StrQuestion = "How was the generation of computer classified?",
                        Options = ["by the device used in memory & processor", "by the speed of computer", "by the model of the computer", "by the accuracy of computer"],
                        Answer = "by the device used in memory & processor",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not a feature of first generation computers?",
                        Options = ["They used vacuum tubes or valves as main electronic component", "They consumed lots of electricity and produced excessive heat", "They used machine language and assembly language to program the machine", "None of above"],
                        Answer = "None of above",
                    },

                    new()
                    {
                        StrQuestion = "CAD stands for",
                        Options = ["Computer aided design", "Computer algorithm for design", "Computer application in design", "All of the above"],
                        Answer = "Computer aided design",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following memories has the shortest access times?",
                        Options = ["Cache memory", "Magnetic bubble memory", "Magnetic core memory", "RAM"],
                        Answer = "Cache memory",
                    },

                    new()
                    {
                        StrQuestion = "A small or intelligent device is so called because it contains within it a",
                        Options = ["Computer", "Microcomputer", "Programmable", "Sensor"],
                        Answer = "Microcomputer",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not a primary storage device?",
                        Options = ["Magnetic tape", "Magnetic disk", "Optical disk", "All of above"],
                        Answer = "All of above",
                    },

                    new()
                    {
                        StrQuestion = "Who invented Analytical engine?",
                        Options = ["Blaise Pascal", "George Bool", "Charles Babbage", "Dr. Herman Hollerith"],
                        Answer = "Charles Babbage",
                    },

                    new()
                    {
                        StrQuestion = "CPU speed of a personal computer is",
                        Options = ["32 KIPS", "100 KIPS", "1 MIPS", "None of these"],
                        Answer = "1 MIPS",
                    },

                    new()
                    {
                        StrQuestion = "Circular division of disks to store and retrieve data are known as",
                        Options = ["tracks", "sectors", "cycles", "rings"],
                        Answer = "tracks",
                    },

                    new()
                    {
                        StrQuestion = "Which statement is valid?",
                        Options = ["1 KB = 1 024 bytes", "1 MB = 2048 bytes", "1 MB = 1 000 kilobytes", "1 KB = 1 000 bytes"],
                        Answer = "1 KB = 1 024 bytes",
                    },

                    new()
                    {
                        StrQuestion = "The least significant bit of the binary number, which is equivalent to any odd decimal number, is:",
                        Options = ["0", "1", "1 or 0", "3"],
                        Answer = "1",
                    },

                    new()
                    {
                        StrQuestion = "The latest PC keyboards use a circuit that senses the movement by the change in its capacitance,",
                        Options = ["Capacitance keyboard", "Mechanical keyboard", "Qwerty keyboard", "Dvorak keyboard"],
                        Answer = "Capacitance keyboard",
                    },

                    new()
                    {
                        StrQuestion = "The Stepped Reckoner was invented by",
                        Options = ["John Napier", "William Oughtred", "Gottfried Leibnitz", "Blaise Pascal"],
                        Answer = "Gottfried Leibnitz",
                    },

                    new()
                    {
                        StrQuestion = "A term used to describe interconnected computer configuration is",
                        Options = ["Multiprogramming", "Modulation", "Multiprocessing", "Micro program sequence"],
                        Answer = "Multiprocessing",
                    },

                    new()
                    {
                        StrQuestion = "While inserting a diskette into the diskette drive of a PC, the diskette’s label side should face",
                        Options = ["East", "North", "South", "Up"],
                        Answer = "Up",
                    },

                    new()
                    {
                        StrQuestion = "Most of the inexpensive personal computers do not have any disk or diskette drive. What is the name of such computers?",
                        Options = ["Home computers", "Diskless computers", "Dedicated computers", "General purpose computers"],
                        Answer = "Diskless computers",
                    },

                    new()
                    {
                        StrQuestion = "What is a light pen?",
                        Options = ["Mechanical Input device", "Optical input device", "Electronic input device", "Optical output device"],
                        Answer = "Optical input device",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following class of computers can not support multiple users simultaneously?",
                        Options = ["Mainframe Computer", "Mini Computers", "Micro Computers", "All of them can support"],
                        Answer = "Micro Computers",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is considered first computer in the world?",
                        Options = ["Z3", "ABC", "Mark I", "None of above"],
                        Answer = "ABC",
                    },

                    new()
                    {
                        StrQuestion = "When a key is pressed on the keyboard, which standard is used for converting the keystroke into the corresponding bits?",
                        Options = ["ANSI", "ASCII", "EBCDIC", "ISO"],
                        Answer = "ASCII",
                    },

                    new()
                    {
                        StrQuestion = "In order to play and hear sound on a computer, one needs:",
                        Options = ["a sound card and speakers", "a microphone", "all of them required", "none of them required"],
                        Answer = "a sound card and speakers",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following devices can be used to directly image printed text?",
                        Options = ["OCR", "OMR", "MICR", "All of above"],
                        Answer = "OCR",
                    },

                    new()
                    {
                        StrQuestion = "For which of the following computers can’t be used?",
                        Options = ["gathering data", "calculating data", "comparing data", "Arranging data"],
                        Answer = "Arranging data",
                    },

                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "The first firm to mass-market a microcomputer as a personal computer was",
                        Options = ["IBM", "Super UNIVAC", "Radio Shaks", "Data General Corporation"],
                        Answer = "Radio Shaks"
                    },

                    new()
                    {
                        StrQuestion = "How many address lines are needed to address each machine location in a 2048 x 4 memory chip?",
                        Options = ["10", "11", "8", "12"],
                        Answer = "11"
                    },

                    new()
                    {
                        StrQuestion = "Properly arranged data is called",
                        Options = ["Field", "Words", "Information", "File"],
                        Answer = "Information"
                    },

                    new()
                    {
                        StrQuestion = "A computer consists of",
                        Options = ["A central processing unit", "A memory", "Input and output unit", "All of the above"],
                        Answer = "All of the above"
                    },

                    new()
                    {
                        StrQuestion = "Why are vacuum tubes also called valves?",
                        Options = [
                            "Because they can amplify the weak signals and make them strong",
                            "Because they can stop or allow the flow of current",
                            "Both of above",
                            "None of above"
                        ],
                        Answer = "Because they can stop or allow the flow of current"
                    },

                    new()
                    {
                        StrQuestion = "John Napier invented Logarithm in",
                        Options = ["1614", "1617", "1620", "None of above"],
                        Answer = "1614"
                    },

                    new()
                    {
                        StrQuestion = "An integrated circuit is",
                        Options = [
                            "A complicated circuit",
                            "An integrating device",
                            "Much costlier than a single transistor",
                            "Fabricated on a tiny silicon chip"
                        ],
                        Answer = "Fabricated on a tiny silicon chip"
                    },

                    new()
                    {
                        StrQuestion = "What type of control pins are needed in a microprocessor to regulate traffic on the bus, in order to prevent two devices from trying to use it at the same time?",
                        Options = ["Bus control", "Interrupts", "Bus arbitration", "Status"],
                        Answer = "Bus arbitration"
                    },

                    new()
                    {
                        StrQuestion = "Where as a computer mouse moves over the table surface, the trackball is",
                        Options = ["Stationary", "Difficult to move", "Dragged", "Moved in small steps"],
                        Answer = "Stationary"
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is used as a primary storage device?",
                        Options = ["Magnetic drum", "Hard Disks", "Floppy", "All of above"],
                        Answer = "Magnetic drum"
                    },
                     new()
                    {
                        StrQuestion = "Abacus was the first",
                        Options = ["electronic computer", "mechanical computer", "electronic calculator", "mechanical calculator"],
                        Answer = "mechanical calculator"
                    },
                    new()
                    {
                        StrQuestion = "If in a computer, 16 bits are used to specify address in a RAM, the number of addresses will be",
                        Options = ["2^16", "65,536", "64K", "Any of the above"],
                        Answer = "65,536"
                    },
                    new()
                    {
                        StrQuestion = "Instructions and memory address are represented by",
                        Options = ["Character code", "Binary codes", "Binary word", "Parity bit"],
                        Answer = "Binary codes"
                    },
                    new()
                    {
                        StrQuestion = "The terminal device that functions as a cash register, computer terminal, and OCR reader is the:",
                        Options = ["Data collection terminal", "OCR register terminal", "Video Display terminal", "POS terminal"],
                        Answer = "POS terminal"
                    },
                    new()
                    {
                        StrQuestion = "A set of flip flops integrated together is called ____",
                        Options = ["Counter", "Adder", "Register", "None of the above"],
                        Answer = "Register"
                    },
                    new()
                    {
                        StrQuestion = "People often call ______ as the brain of computer system",
                        Options = ["Control Unit", "Arithmetic Logic Unit", "Central Processing Unit", "Storage Unit"],
                        Answer = "Central Processing Unit"
                    },
                    new()
                    {
                        StrQuestion = "Which is used for manufacturing chips?",
                        Options = ["Bus", "Control unit", "Semiconductors", "A and b only"],
                        Answer = "Semiconductors"
                    },
                    new()
                    {
                        StrQuestion = "The value of each bead in heaven is",
                        Options = ["1", "3", "5", "7"],
                        Answer = "5"
                    },
                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Multi user systems provided cost savings for small business because they use a single processing unit to link several",
                        Options = ["Personal computers", "Workstations", "Dumb terminals", "Mainframes"],
                        Answer = "Dumb terminals"
                    },
                    new()
                    {
                        StrQuestion = "What are the three decisions making operations performed by the ALU of a computer?",
                        Options = ["Greater than", "Less than", "Equal to", "All of the above"],
                        Answer = "All of the above"
                    },
                    new()
                    {
                        StrQuestion = "The word processing task associated with changing the appearance of a document is",
                        Options = ["Editing", "Writing", "Formatting", "All of above"],
                        Answer = "Formatting"
                    },
                    new()
                    {
                        StrQuestion = "Nepal brought a computer for census of 2028 BS. This computer was of",
                        Options = ["first generation", "second generation", "third generation", "fourth generation"],
                        Answer = "second generation"
                    },
                    new()
                    {
                        StrQuestion = "Algorithm and Flow chart help us to",
                        Options = [
                            "Know the memory capacity",
                            "Identify the base of a number system",
                            "Direct the output to a printer",
                            "Specify the problem completely and clearly"
                        ],
                        Answer = "Specify the problem completely and clearly"
                    },
                    new()
                    {
                        StrQuestion = "Which statement is valid about computer program?",
                        Options = [
                            "It is understood by a computer",
                            "It is understood by programmer",
                            "It is understood user",
                            "Both a & b"
                        ],
                        Answer = "Both a & b"
                    },
                    new()
                    {
                        StrQuestion = "The difference between memory and storage is that memory is _____ and storage is __",
                        Options = ["Temporary, permanent", "Permanent, temporary", "Slow, fast", "All of above"],
                        Answer = "Temporary, permanent"
                    },
                    new()
                    {
                        StrQuestion = "When was Pascaline invented?",
                        Options = ["1617", "1620", "1642", "1837"],
                        Answer = "1642"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following statement is valid?",
                        Options = [
                            "Lady Augusta is the first programmer",
                            "Ada is the daughter of Lord Byron, a famous English poet",
                            "ADA is a programming language developed by US Defense",
                            "All of above"
                        ],
                        Answer = "All of above"
                    },
                    new()
                    {
                        StrQuestion = "A compiler is a translating program which",
                        Options = [
                            "Translates instruction of a high level language into machine language",
                            "Translates entire source program into machine language program",
                            "It is not involved in program’s execution",
                            "All of above"
                        ],
                        Answer = "All of above"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is called low level languages?",
                        Options = ["Machine language", "Assembly language", "Both of the above", "None of above"],
                        Answer = "Both of the above",
                    },

                    new()
                    {
                        StrQuestion = "A factor which would strongly influence a business person to adopt a computer is its",
                        Options = ["Accuracy", "Reliability", "Speed", "All of above"],
                        Answer = "All of above",
                    },

                    new()
                    {
                        StrQuestion = "Who invented punched cards?",
                        Options = ["Charles Babbage", "Dr. Herman Hollerith", "Howard Aikin", "Joseph Jacquard"],
                        Answer = "Dr. Herman Hollerith",
                    },

                    new()
                    {
                        StrQuestion = "Each model of a computer has a unique",
                        Options = ["Assembly of a computer", "Machine language", "High level language", "All of the above"],
                        Answer = "Machine language",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not a primary storage device?",
                        Options = ["Magnetic tape", "Magnetic disk", "Optical disk", "All of the above"],
                        Answer = "All of the above",
                    },

                    new()
                    {
                        StrQuestion = "In a punched card system, data is processed by a",
                        Options = ["Keypunch machine, sorter and posting machine", "Accounting machine, posting machine, and billing machine", "Sorter, posting machine, and billing machine", "Accounting machine, keypunch machine and sorter"],
                        Answer = "Accounting machine, keypunch machine and sorter",
                    },

                    new()
                    {
                        StrQuestion = "Which device is required for the Internet connection?",
                        Options = ["Joystick", "Modem", "CD Drive", "NIC Card"],
                        Answer = "Modem",
                    },
                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is required when more than one person uses a central computer at the same time?",
                        Options = ["Light pen", "Mouse", "Digitizer", "Terminal"],
                        Answer = "Terminal"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is the first computer to use Stored Program Concept?",
                        Options = ["UNIVAC", "ENIAC", "EDSAC", "None of above"],
                        Answer = "EDSAC"
                    },
                    new()
                    {
                        StrQuestion = "The term gigabyte refers to",
                        Options = ["1024 bytes", "1024 kilobytes", "1024 megabytes", "1024 gigabyte"],
                        Answer = "1024 megabytes"
                    },
                    new()
                    {
                        StrQuestion = "In which year was UK’s premier computing event called 'The which computer' started?",
                        Options = ["1980", "1985", "1986", "1987"],
                        Answer = "1980"
                    },
                    new()
                    {
                        StrQuestion = "Once you load the suitable program and provide required data, computer does not need human intervention. This feature is known as",
                        Options = ["Accuracy", "Reliability", "Versatility", "Automatic"],
                        Answer = "Automatic"
                    },
                    new()
                    {
                        StrQuestion = "What is a brand?",
                        Options = [
                            "The name of companies that made computers",
                            "The name of product a company gives to identify its product in market",
                            "A name of class to indicate all similar products from different companies",
                            "All of above"
                        ],
                        Answer = "The name of product a company gives to identify its product in market"
                    },
                    new()
                    {
                        StrQuestion = "Machine language is",
                        Options = ["Machine dependent", "Difficult to program", "Error prone", "All of above"],
                        Answer = "All of above"
                    },
                    new()
                    {
                        StrQuestion = "A byte consists of",
                        Options = ["One bit", "Four bits", "Eight bits", "Sixteen bits"],
                        Answer = "Eight bits"
                    },
                    new()
                    {
                        StrQuestion = "Modern Computers are very reliable but they are not",
                        Options = ["Fast", "Powerful", "Infallible", "Cheap"],
                        Answer = "Infallible"
                    },
                    new()
                    {
                        StrQuestion = "What is the date when Babbage conceived Analytical engine",
                        Options = ["1642", "1837", "1880", "1850"],
                        Answer = "1837"
                    }
                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which of the following is not valid statement?",
                        Options = [
                            "Hard is referred to mean something temporary",
                            "Hard is used to mean something tangible",
                            "Soft is used to mean something permanent",
                            "Soft is used to mean something tangible"
                        ],
                        Answer = "Soft is used to mean something tangible"
                    },
                    new()
                    {
                        StrQuestion = "Digital devices are",
                        Options = ["Digital Clock", "Automobile speed meter", "Clock with a dial and two hands", "All of them"],
                        Answer = "Digital Clock"
                    },
                    new()
                    {
                        StrQuestion = "Primary memory stores",
                        Options = ["Data alone", "Programs alone", "Results alone", "All of these"],
                        Answer = "All of these"
                    },
                    new()
                    {
                        StrQuestion = "After copying the content how many times can you paste?",
                        Options = ["1", "16", "32", "Many"],
                        Answer = "Many"
                    },
                    new()
                    {
                        StrQuestion = "WAN stands for",
                        Options = ["Wap Area Network", "Wide Area Network", "Wide Array Net", "Wireless Area Network"],
                        Answer = "Wide Area Network"
                    },
                    new()
                    {
                        StrQuestion = "An error in computer data is called",
                        Options = ["Chip", "Bug", "CPU", "Storage device"],
                        Answer = "Bug"
                    },
                    new()
                    {
                        StrQuestion = "The instructions for starting the computer are house on",
                        Options = ["Random access memory", "CD-Rom", "Read only memory chip", "All of above"],
                        Answer = "Read only memory chip"
                    },
                    new()
                    {
                        StrQuestion = "1 nibble equals to",
                        Options = ["1 bits", "2 bits", "4 bits", "8 bits"],
                        Answer = "4 bits"
                    },
                    new()
                    {
                        StrQuestion = "Perforated paper used as input of output media is known as",
                        Options = ["paper tapes", "magnetic tape", "punched papers tape", "card punch"],
                        Answer = "paper tapes"
                    },
                    new()
                    {
                        StrQuestion = "The secondary storage devices can only store data but they cannot perform",
                        Options = ["Arithmetic Operation", "Logic operation", "Fetch operations", "Either of the above"],
                        Answer = "Either of the above"
                    }
                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which American computer company is called Big Blue?",
                        Options = ["Microsoft", "Compaq Corp", "IBM", "Tandy Svenson"],
                        Answer = "IBM"
                    },
                    new()
                    {
                        StrQuestion = "It was in 2028 BS the _________ was brought in to calculate census data.",
                        Options = ["IBM 1400", "IBM 1401", "ICL 2950", "None of above"],
                        Answer = "IBM 1401"
                    },
                    new()
                    {
                        StrQuestion = "Who is the inventor of ABC Computer?",
                        Options = ["John v. Atanasoff", "Clifford Berry", "Both of above", "None of above"],
                        Answer = "Both of above"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is the largest unit?",
                        Options = ["data", "field", "record", "database file"],
                        Answer = "database file"
                    },
                    new()
                    {
                        StrQuestion = "Find out who is not the inventor of transistors among following names",
                        Options = ["John Burdeen", "William Shockley", "Walter Brattain", "Lee de Forest"],
                        Answer = "Lee de Forest"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is not true for a magnetic disk?",
                        Options = [
                            "It is expensive relative to magnetic tape",
                            "It provides only sequential access to stored data",
                            "Users can easily update records by writing over the old data",
                            "All of above"
                        ],
                        Answer = "It provides only sequential access to stored data"
                    },
                    new()
                    {
                        StrQuestion = "A disadvantage of the laser printer is",
                        Options = [
                            "It is quieter than an impact printer",
                            "It is very slow",
                            "The output is of a lower quality",
                            "None of the above"
                        ],
                        Answer = "None of the above"
                    },
                    new()
                    {
                        StrQuestion = "The most commonly used standard data code to represent alphabetical, numerical and punctuation characters used in electronic data processing system is called",
                        Options = ["ASCII", "EBCDIC", "BCD", "All of above"],
                        Answer = "ASCII"
                    },
                    new()
                    {
                        StrQuestion = "Which access method is used to access cassette tape?",
                        Options = ["Direct", "Sequential", "Both of the above", "None of the above"],
                        Answer = "Sequential"
                    },
                    new()
                    {
                        StrQuestion = "A Compiler is ____",
                        Options = [
                            "a combination of computer hardware",
                            "a program which translates from one high-level language to another",
                            "a program which translates from one high-level to a machine level language",
                            "None of these"
                        ],
                        Answer = "a program which translates from one high-level to a machine level language"
                    }
                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which unit holds data temporarily?",
                        Options = ["Input unit", "Secondary storage unit", "Output Unit", "Primary Memory Unit"],
                        Answer = "Primary Memory Unit"
                    },
                    new()
                    {
                        StrQuestion = "The computer size was very large in",
                        Options = ["First Generation", "Second Generation", "Third Generation", "Fourth Generation"],
                        Answer = "First Generation"
                    },
                    new()
                    {
                        StrQuestion = "A name or number used to identify storage location devices?",
                        Options = ["A byte", "A record", "An address", "All of above"],
                        Answer = "An address"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is not computer language?",
                        Options = ["High level language", "Medium level language", "Low level language", "All of the above"],
                        Answer = "Medium level language"
                    },
                    new()
                    {
                        StrQuestion = "Reading data is performed in magnetic disk by",
                        Options = ["Read/write leads", "Sectors", "Track", "Lower surface"],
                        Answer = "Read/write leads"
                    },
                    new()
                    {
                        StrQuestion = "IBM 7000 digital computer",
                        Options = [
                            "Belongs to second generation",
                            "Uses VLSI",
                            "Employs semiconductor memory",
                            "Has modular constructions"
                        ],
                        Answer = "Belongs to second generation"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is not electro-mechanical computer?",
                        Options = ["Mark I", "ABC", "Zuse", "UNIVAC"],
                        Answer = "UNIVAC"
                    },
                    new()
                    {
                        StrQuestion = "The term ‘computer’ is derived from",
                        Options = ["Greek language", "Sanskrit language", "Latin language", "German language"],
                        Answer = "Latin language"
                    },
                    new()
                    {
                        StrQuestion = "Which statement is valid about magnetic tape?",
                        Options = [
                            "It is a plastic ribbon",
                            "It is coated on both sides with iron oxide",
                            "It can be erased and reused",
                            "All of above"
                        ],
                        Answer = "All of above"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is first generation computer?",
                        Options = ["EDSAC", "IBM 1401", "CDC 1604", "ICL 2950"],
                        Answer = "EDSAC"
                    }
                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "A hard copy would be prepared on a",
                        Options = ["Line printer", "Dot matrix Printer", "Typewriter terminal", "All of the above"],
                        Answer = "All of the above"
                    },
                    new()
                    {
                        StrQuestion = "The term GIGO is related to which characteristics of computers?",
                        Options = ["Speed", "Automatic", "Accuracy", "Reliability"],
                        Answer = "Accuracy"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following programming language were used in first generation computers?",
                        Options = ["Machine language", "Assembly language", "Both of above", "None of above"],
                        Answer = "Machine language"
                    },
                    new()
                    {
                        StrQuestion = "To locate a data item for storage is",
                        Options = ["Field", "Feed", "Database", "Fetch"],
                        Answer = "Fetch"
                    },
                    new()
                    {
                        StrQuestion = "Who used punched cards practically for the first time in the history of computers?",
                        Options = ["Charles Babbage", "Dr. Herman Hollerith", "Howard Aikin", "Joseph Jacquard"],
                        Answer = "Dr. Herman Hollerith"
                    },
                    new()
                    {
                        StrQuestion = "Hard disk is coated in both sides with",
                        Options = ["Magnetic metallic oxide", "Optical metallic oxide", "Carbon layer", "All of the above"],
                        Answer = "Magnetic metallic oxide"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following term means to reckon?",
                        Options = ["putare", "com", "computa", "computar"],
                        Answer = "putare"
                    },
                    new()
                    {
                        StrQuestion = "An input /output device at which data enters or leaves a computer system is",
                        Options = ["Keyboard", "Terminal", "Printer", "Plotter"],
                        Answer = "Terminal"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is first generation of computer",
                        Options = ["EDSAC", "IBM-1401", "CDC-1604", "ICL-2900"],
                        Answer = "EDSAC"
                    },
                    new()
                    {
                        StrQuestion = "A name or number used to identify a storage location is called",
                        Options = ["A byte", "A record", "An address", "All of above"],
                        Answer = "An address"
                    }
                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Computer professionals working in a computer centre are",
                        Options = ["Software", "Firmware", "Hardware", "Humanware"],
                        Answer = "Humanware"
                    },

                    new()
                    {
                        StrQuestion = "The contents of information are stored in",
                        Options = ["Memory data register", "Memory address register", "Memory arithmetic registers", "Memory access register"],
                        Answer = "Memory data register"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is correct full form of BCD?",
                        Options = ["Binary Coded Decimal", "Bit Coded Decimal", "Binary Coded Digit", "Bit Coded Digit"],
                        Answer = "Binary Coded Decimal"
                    },
                    new()
                    {
                        StrQuestion = "Which was the world’s first microcomputer that used Intel 80386 microprocessor chip?",
                        Options = ["IBM PS/2", "HP-9830", "DeskPro-386", "IBM-360"],
                        Answer = "DeskPro-386"
                    },
                    new()
                    {
                        StrQuestion = "The qualitative or quantitative attribute of a variable or set of variables is termed as",
                        Options = ["data", "information", "both of above", "none of above"],
                        Answer = "data"
                    },
                    new()
                    {
                        StrQuestion = "Main storage is also called",
                        Options = ["Accumulator", "Control Unit", "Register Unit", "Memory"],
                        Answer = "Memory"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following are (is) considered to be video component?",
                        Options = ["Resolution", "Color depth", "Refresh rate", "All of the alcove"],
                        Answer = "All of the alcove"
                    },
                    new()
                    {
                        StrQuestion = "For what Antikyathera was used?",
                        Options = ["For counting", "For Calculating tax collection", "For calculating astronomical positions", "For calculating firing weapons"],
                        Answer = "For calculating astronomical positions"
                    },
                    new()
                    {
                        StrQuestion = "Memory unit is one part of",
                        Options = ["Input device", "Control unit", "Output device", "Central Processing Unit"],
                        Answer = "Central Processing Unit"
                    },
                    new()
                    {
                        StrQuestion = "Microprocessors can be used to make",
                        Options = ["Computer", "Digital systems", "Calculators", "All of the above"],
                        Answer = "All of the above"
                    },
                    new()
                    {
                        StrQuestion = "Which statement is valid about computer program?",
                        Options = [
                            "High level languages must be converted into machine language to execute",
                            "High level language programs are more efficient and faster to execute",
                            "It is more difficult to identify errors in high level language program than in low level programs",
                            "All of above"
                        ],
                        Answer = "High level languages must be converted into machine language to execute"
                    },
                    new()
                    {
                        StrQuestion = "By programmable machine we mean",
                        Options = [
                            "computers",
                            "modern television",
                            "washing machines",
                            "anything that can be set to perform different tasks with suitable programs"
                        ],
                        Answer = "anything that can be set to perform different tasks with suitable programs"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is a secondary memory device?",
                        Options = ["Keyboard", "Disk", "ALU", "All of the above"],
                        Answer = "Disk"
                    },
                    new()
                    {
                        StrQuestion = "The memory which is programmed at the time it is manufactured",
                        Options = ["ROM", "RAM", "PROM", "EPROM"],
                        Answer = "ROM"
                    },
                    new()
                    {
                        StrQuestion = "One of the popular mass storage device is CD ROM. What does CD ROM stand for?",
                        Options = [
                            "Compactable Read Only Memory",
                            "Compact Data Read Only Memory",
                            "Compactable Disk Read Only Memory",
                            "Compact Disk Read Only Memory"
                        ],
                        Answer = "Compact Disk Read Only Memory"
                    },
                    new()
                    {
                        StrQuestion = "Identify the true statement",
                        Options = [
                            "Computers are 100% accurate but it can suffer from GIGO",
                            "Computers are reliable because they use electronic component which have very low failure rate",
                            "Computer is never tired and does not suffer from boredom",
                            "All of above"
                        ],
                        Answer = "All of above"
                    },
                    new()
                    {
                        StrQuestion = "FORTRAN is",
                        Options = ["File Translation", "Format Translation", "Formula Translation", "Floppy Translation"],
                        Answer = "Formula Translation"
                    },
                    new()
                    {
                        StrQuestion = "The programs which are as permanent as hardware and stored in ROM is known as",
                        Options = ["Hardware", "Software", "Firmware", "ROM ware"],
                        Answer = "Firmware"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following memories must be refreshed many times per second?",
                        Options = ["Static RAM", "Dynamic RAM", "EPROM", "ROM"],
                        Answer = "Dynamic RAM"
                    }
                ]
            },



            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which is not a computer classification?",
                        Options = ["mainframe", "maxframe", "mini", "notebook"],
                        Answer = "maxframe"
                    },
                    new()
                    {
                        StrQuestion = "The control unit of a microprocessor",
                        Options = [
                            "Stores data in the memory",
                            "Accepts input data from keyboard",
                            "Performs arithmetic/logic function",
                            "None of above"
                        ],
                        Answer = "None of above"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is internal memory?",
                        Options = ["Disks", "Pen Drives", "RAM", "CDs"],
                        Answer = "RAM"
                    },
                    new()
                    {
                        StrQuestion = "Which operation is not performed by computer?",
                        Options = ["Inputting", "Processing", "Controlling", "Understanding"],
                        Answer = "Understanding"
                    },
                    new()
                    {
                        StrQuestion = "Floppy disks which are made from flexible plastic material are also called?",
                        Options = ["Hard disks", "High-density disks", "Diskettes", "Templates"],
                        Answer = "Diskettes"
                    },
                    new()
                    {
                        StrQuestion = "The magnetic storage chip used to provide non-volatile direct access storage of data and that have no moving parts are known as",
                        Options = [
                            "Magnetic core memory",
                            "Magnetic tape memory",
                            "Magnetic disk memory",
                            "Magnetic bubble memory"
                        ],
                        Answer = "Magnetic bubble memory"
                    },
                    new()
                    {
                        StrQuestion = "A collection of related instructions organized for a common purpose is referred to as",
                        Options = ["File", "Database", "Program", "None of above"],
                        Answer = "Program"
                    },
                    new()
                    {
                        StrQuestion = "Plotter accuracy is measured in terms of repeatability and",
                        Options = ["Buffer size", "Resolution", "Vertical dimensions", "Intelligence"],
                        Answer = "Resolution"
                    },
                    new()
                    {
                        StrQuestion = "Computer instructions written with the use of English words instead of binary machine code is called",
                        Options = ["Mnemonics", "Symbolic code", "Gray codes", "Opcode"],
                        Answer = "Symbolic code"
                    },
                    new()
                    {
                        StrQuestion = "Which language is directly understood by the computer without translation program?",
                        Options = ["Machine language", "Assembly language", "High level language", "None of above"],
                        Answer = "Machine language"
                    },
                    new()
                    {
                        StrQuestion = "On which aspect the analog computers are better than digital?",
                        Options = ["Speed", "Accuracy", "Reliability", "Automatic"],
                        Answer = "Speed"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following processors use RISC technology?",
                        Options = ["486dx", "Power PC", "486sx", "6340"],
                        Answer = "Power PC"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following machine was not invented by Charles Babbage?",
                        Options = ["Tabulating Machine", "Analytical Engine", "Difference Engine", "Both C and D"],
                        Answer = "Tabulating Machine"
                    },
                    new()
                    {
                        StrQuestion = "How many numbers could ENIAC store in its internal memory?",
                        Options = ["100", "20", "80", "40"],
                        Answer = "20"
                    },
                    new()
                    {
                        StrQuestion = "The subject of cybernetics deals with the science of",
                        Options = ["Genetics", "Control and communication", "Molecular biology", "Biochemistry"],
                        Answer = "Control and communication"
                    },
                    new()
                    {
                        StrQuestion = "Why ABC is considered electro-mechanical computer?",
                        Options = [
                            "Because it was invented before electronic computers were developed",
                            "Because there are wheels, drums, bars to rotate and move to produce result",
                            "Because they use the flow of electrons in different component",
                            "None of above"
                        ],
                        Answer = "Because there are wheels, drums, bars to rotate and move to produce result"
                    },
                    new()
                    {
                        StrQuestion = "Binary circuit elements have",
                        Options = ["One stable state", "Two stable state", "Three stable state", "None of above"],
                        Answer = "Two stable state"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is used for manufacturing chips?",
                        Options = ["Control bus", "Control unit", "Parity unit", "Semiconductor"],
                        Answer = "Semiconductor"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is not a micro computer?",
                        Options = ["Laptop PCs", "Tablet PCs", "Desktop PCs", "None of above"],
                        Answer = "None of above"
                    },
                    new()
                    {
                        StrQuestion = "The value of each bead in earth is",
                        Options = ["1", "3", "5", "7"],
                        Answer = "1"
                    },
                    new()
                    {
                        StrQuestion = "When did John Napier develop logarithm?",
                        Options = ["1416", "1614", "1641", "1804"],
                        Answer = "1614"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following terms is the most closely related to main memory?",
                        Options = ["Non volatile", "Permanent", "Control unit", "Temporary"],
                        Answer = "Temporary"
                    },
                    new()
                    {
                        StrQuestion = "Which was the world’s first minicomputer and when was it introduced?",
                        Options = ["PDP-I, 1958", "IBM System/36, 1960", "PDP-II, 1961", "VAX 11/780, 1962"],
                        Answer = "PDP-I, 1958"
                    },
                    new()
                    {
                        StrQuestion = "A group of magnetic tapes, videos or terminals usually under the control of one master is",
                        Options = ["Cylinder", "Surface", "Track", "Cluster"],
                        Answer = "Cluster"
                    },
                    new()
                    {
                        StrQuestion = "The word length of a computer is measured in",
                        Options = ["Bytes", "Millimeters", "Meters", "Bits"],
                        Answer = "Bits"
                    },
                    new()
                    {
                        StrQuestion = "What type of memory is not directly addressable by the CPU and requires special software called EMS (expanded memory specification)?",
                        Options = ["Extended", "Expanded", "Base", "Conventional"],
                        Answer = "Expanded"
                    },
                    new()
                    {
                        StrQuestion = "Which unit holds data permanently?",
                        Options = ["Input unit", "Secondary storage unit", "Output Unit", "Primary Memory Unit"],
                        Answer = "Secondary storage unit"
                    },
                    new()
                    {
                        StrQuestion = "Before a disk can be used to store data. It must be_______",
                        Options = ["Formatted", "Reformatted", "Addressed", "None of the above"],
                        Answer = "Formatted"
                    },
                    new()
                    {
                        StrQuestion = "Computer system comprises of major units",
                        Options = [
                            "input unit, output unit, control unit",
                            "input unit, output unit, control unit and storage",
                            "input unit, output unit, central processing unit and storage unit",
                            "input, output and storage units"
                        ],
                        Answer = "input unit, output unit, central processing unit and storage unit"
                    },
                    new()
                    {
                        StrQuestion = "The first general purpose electronic digital computer in the world was",
                        Options = ["UNIVAC", "EDVAC", "ENIAC", "All of above"],
                        Answer = "ENIAC"
                    }
                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What do you call the translator which takes assembly language program as input & produce machine language code as output?",
                        Options = ["Compiler", "Interpreter", "Debugger", "Assembler"],
                        Answer = "Assembler"
                    },
                    new()
                    {
                        StrQuestion = "Serial access memories are useful in applications where",
                        Options = [
                            "Data consists of numbers",
                            "Short access time is required",
                            "Each stored word is processed differently",
                            "Data naturally needs to flow in and out in serial form"
                        ],
                        Answer = "Data naturally needs to flow in and out in serial form"
                    },
                    new()
                    {
                        StrQuestion = "In ________ mode, the communication channel is used in both directions at the same time?",
                        Options = ["Full-duplex", "Simplex", "Half-duplex", "None of the above"],
                        Answer = "Full-duplex"
                    },
                    new()
                    {
                        StrQuestion = "Who invented Slide Rules?",
                        Options = ["John Napier", "William Oughtred", "Gottfried Leibnitz", "Blaise Pascal"],
                        Answer = "William Oughtred"
                    },
                    new()
                    {
                        StrQuestion = "The proper definition of a modern digital computer is",
                        Options = [
                            "An electronic automated machine that can solve problems involving words and numbers",
                            "A more sophisticated and modified electronic pocket calculator",
                            "Any machine that can perform mathematical operations",
                            "A machine that works on binary code"
                        ],
                        Answer = "An electronic automated machine that can solve problems involving words and numbers"
                    },
                    new()
                    {
                        StrQuestion = "Memory is made up of",
                        Options = ["Set of wires", "Set of circuits", "Large number of cells", "All of these"],
                        Answer = "Large number of cells"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is the most powerful computers?",
                        Options = ["Mainframe Computer", "Mini Computers", "Micro Computers", "Super Computers"],
                        Answer = "Super Computers"
                    },
                    new()
                    {
                        StrQuestion = "Which of the printers used in conjunction with computers uses dry ink powder?",
                        Options = ["Daisy wheel printer", "Line printer", "Laser printer", "Thermal printer"],
                        Answer = "Laser printer"
                    },
                    new()
                    {
                        StrQuestion = "What is the path from which data flow in a computer system is known as",
                        Options = ["Car", "Bus", "Truck", "Road"],
                        Answer = "Bus"
                    },
                    new()
                    {
                        StrQuestion = "Which term is used to describe RAM?",
                        Options = ["Dynamic RAM (DRAM)", "Static RAM (SRAM)", "Video RAM (VRAM)", "All of the above"],
                        Answer = "All of the above"
                    },
                    new()
                    {
                        StrQuestion = "In which year was chip used inside the computer for the first time?",
                        Options = ["1964", "1975", "1999", "1944"],
                        Answer = "1975"
                    },
                    new()
                    {
                        StrQuestion = "Assembly language started to be used from",
                        Options = ["first generation computers", "second generation computers", "third generation computers", "fourth generation computers"],
                        Answer = "second generation computers"
                    },
                    new()
                    {
                        StrQuestion = "Which technology is more reliable?",
                        Options = ["Mechanical", "Electro-Mechanical", "Electronic", "For reliability it does not matter. So all of above are reliable"],
                        Answer = "Electronic"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is not an XT microprocessor?",
                        Options = ["8006", "8086", "8088", "None of above"],
                        Answer = "8006"
                    },
                    new()
                    {
                        StrQuestion = "Hard disk is coated in both side with",
                        Options = ["Magnetic metallic oxide", "Optical metallic oxide", "Carbon layer", "All of the above"],
                        Answer = "Magnetic metallic oxide"
                    },
                    new()
                    {
                        StrQuestion = "ASCII stands for",
                        Options = [
                            "American Stable Code for International Interchange",
                            "American Standard Case for Institutional Interchange",
                            "American Standard Code for Information Interchange",
                            "American Standard Code for Interchange Information"
                        ],
                        Answer = "American Standard Code for Information Interchange"
                    },
                    new()
                    {
                        StrQuestion = "Raw facts and figures about any particular topic are",
                        Options = ["Information", "facts", "data", "none of above"],
                        Answer = "data"
                    },
                    new()
                    {
                        StrQuestion = "A computer can solve more than one kind of problem. This is related to which of the following characteristics?",
                        Options = ["Accuracy", "Reliability", "Versatility", "Automatic"],
                        Answer = "Versatility"
                    },
                    new()
                    {
                        StrQuestion = "From which generation computers the printers were used?",
                        Options = ["first", "second", "third", "fourth"],
                        Answer = "second"
                    },
                    new()
                    {
                        StrQuestion = "How many symbols exist in Baudot code?",
                        Options = ["32", "116", "58", "76"],
                        Answer = "32"
                    }
                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Following IC chip integrates 100 thousands electronic components per chip",
                        Options = ["SSI", "MSI", "LSI", "VLSI"],
                        Answer = "VLSI"
                    },
                    new()
                    {
                        StrQuestion = "An application program that helps the user to change any number and immediately see the result of that change is",
                        Options = ["Desktop publishing program", "Database", "Spreadsheet", "All of above"],
                        Answer = "Spreadsheet"
                    },
                    new()
                    {
                        StrQuestion = "In 1830, Charles Babbage designed a machine called the Analytical Engine which he showed at the Paris Exhibition. In which year was it exhibition?",
                        Options = ["1820", "1860", "1855", "1870"],
                        Answer = "1855"
                    },
                    new()
                    {
                        StrQuestion = "What is the name of the new color laptop computer which is powered by a 386 processor at 33 MHz and is built by Epson?",
                        Options = ["AX3/33", "NEC-20", "Magnum 2000", "HCL-3000"],
                        Answer = "AX3/33"
                    },
                    new()
                    {
                        StrQuestion = "In analog computer",
                        Options = [
                            "Input is first converted to digital form",
                            "Input is never converted to digital form",
                            "Output is displayed in digital form",
                            "All of the above"
                        ],
                        Answer = "Input is never converted to digital form"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following computer is not invented by J.P. Eckert and John Mauchly?",
                        Options = ["ENIAC", "EDVAC", "UNIVAC", "EDSAC"],
                        Answer = "EDSAC"
                    },
                    new()
                    {
                        StrQuestion = "When was the company named IBM?",
                        Options = ["1914", "1924", "1975", "None of above"],
                        Answer = "1924"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following storage device can store the largest amount of data?",
                        Options = ["Hard Disks", "Flash Disks", "Blu-Ray Disks", "DVDs"],
                        Answer = "Hard Disks"
                    },
                    new()
                    {
                        StrQuestion = "Who invented Mark I?",
                        Options = ["Howard Aikin", "J. P. Eckert", "John Mauchley", "John v. Atanasoff"],
                        Answer = "Howard Aikin"
                    },
                    new()
                    {
                        StrQuestion = "ALU is",
                        Options = ["Arithmetic Logic Unit", "Array Logic Unit", "Application Logic Unit", "None of above"],
                        Answer = "Arithmetic Logic Unit"
                    },
                    new()
                    {
                        StrQuestion = "A computer program that converts an entire program into machine language at one time is called a/an",
                        Options = ["Interpreter", "CPU", "Compiler", "Simulator"],
                        Answer = "Compiler"
                    },
                    new()
                    {
                        StrQuestion = "When did arch rivals IBM and Apple Computers Inc. decide to join hands?",
                        Options = ["1978", "1984", "1990", "1991"],
                        Answer = "1991"
                    },
                    new()
                    {
                        StrQuestion = "The purpose of vacuum tube was to NOT act like",
                        Options = ["an amplifier", "a switch", "a router", "None of above"],
                        Answer = "a router"
                    },
                    new()
                    {
                        StrQuestion = "As compared to diskettes, the hard disks are",
                        Options = ["More expensive", "More portable", "Less rigid", "Slowly accessed"],
                        Answer = "More expensive"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is the most quickly accessible storage?",
                        Options = ["RAM", "Registers", "Disks", "Pen Drive"],
                        Answer = "Registers"
                    },
                    new()
                    {
                        StrQuestion = "The octal equivalence of 111010 is",
                        Options = ["81", "72", "71", "None of above"],
                        Answer = "72"
                    },
                    new()
                    {
                        StrQuestion = "Excessive parallel processing is related to",
                        Options = ["First generation", "Fourth generation", "Fifth Generation", "Third generation"],
                        Answer = "Fifth Generation"
                    },
                    new()
                    {
                        StrQuestion = "Second generation computers were developed during",
                        Options = ["1949 to 1955", "1956 to 1965", "1965 to 1970", "1970 to 1990"],
                        Answer = "1956 to 1965"
                    },
                    new()
                    {
                        StrQuestion = "What do you call a single point on a computer screen?",
                        Options = ["Cell", "Element", "Pixel", "Bit"],
                        Answer = "Pixel"
                    },
                    new()
                    {
                        StrQuestion = "Mostly which of the following device is used to carry user files?",
                        Options = ["Floppy Disk", "Hard Disk", "RAM", "CDROM"],
                        Answer = "Floppy Disk"
                    }
                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which of the following computer implemented binary numbers, perform calculations using electronics and implemented separate computation and memory for the first time?",
                        Options = ["Mark I", "ABC", "Z3", "None of above"],
                        Answer = "Z3"
                    },
                    new()
                    {
                        StrQuestion = "FORTRAN is a programming language. What does FORTRAN stand for?",
                        Options = ["File Translation", "Format Translation", "Formula Translation", "Floppy Translation"],
                        Answer = "Formula Translation"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following memories needs refreshing?",
                        Options = ["SRAM", "DRAM", "ROM", "All of above"],
                        Answer = "DRAM"
                    },
                    new()
                    {
                        StrQuestion = "Can you tell what passes into and out from the computer via its ports?",
                        Options = ["Data", "Bytes", "Graphics", "Pictures"],
                        Answer = "Data"
                    },
                    new()
                    {
                        StrQuestion = "An output device that uses words or messages recorded on a magnetic medium to produce audio response is",
                        Options = ["Magnetic tape", "Voice response unit", "Voice recognition unit", "Voice band"],
                        Answer = "Voice response unit"
                    },
                    new()
                    {
                        StrQuestion = "Which of the items below are considered removable storage media?",
                        Options = ["Removable hard disk cartridges", "(Magneto-optical) disk", "Flexible disks cartridges", "All of the above"],
                        Answer = "All of the above"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is not purely output device?",
                        Options = ["Screen", "Printer", "Speaker", "Plotter"],
                        Answer = "Screen"
                    },
                    new()
                    {
                        StrQuestion = "Who developed a mechanical device in the 17th century that could add, subtract, multiply, divide and find square roots?",
                        Options = ["Napier", "Babbage", "Pascal", "Leibniz"],
                        Answer = "Leibniz"
                    },
                    new()
                    {
                        StrQuestion = "The first Macintosh computer was from which generation?",
                        Options = ["First generation", "Second generation", "Third generation", "Fourth generation"],
                        Answer = "Fourth generation"
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is not a form of data?",
                        Options = ["Numbers and characters", "Images", "Sound", "None of above"],
                        Answer = "None of above"
                    },
                    new()
                    {
                        StrQuestion = "When was the transistor invented?",
                        Options = ["1948", "1938", "1958", "1968"],
                        Answer = "1948",
                    },

                    new()
                    {
                        StrQuestion = "In the third generation of computers,",
                        Options = ["Distributed data processing first became popular", "An operating system was first developed", "High level procedural languages were first used", "Online real-time systems first became popular"],
                        Answer = "High level procedural languages were first used",
                    },

                    new()
                    {
                        StrQuestion = "Most important advantage of an IC is its",
                        Options = ["Easy replacement in case of circuit failure", "Extremely high reliability", "Reduced cost", "Lower power consumption"],
                        Answer = "Extremely high reliability",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following magazines covers only the IBM PC and its compatibles?",
                        Options = ["Byte", "PC Magazine", "Personal Computing", "Interface Age"],
                        Answer = "PC Magazine",
                    },

                    new()
                    {
                        StrQuestion = "UNIVAC was a first-generation computer. What is its full form?",
                        Options = ["Universal Automatic Computer", "Universal Array Computer", "Unique Automatic Computer", "Unvalued Automatic Computer"],
                        Answer = "Universal Automatic Computer",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is required when more than one person uses a central computer at the same time?",
                        Options = ["Terminal", "Light pen", "Digitizer", "Mouse"],
                        Answer = "Terminal",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not an output device?",
                        Options = ["Portable Projector", "Printer", "Flat Screen", "Touch Screen"],
                        Answer = "Touch Screen",
                    },

                    new()
                    {
                        StrQuestion = "Personal computers used a number of chips mounted on a main circuit board. What is the common name for such boards?",
                        Options = ["Daughterboard", "Motherboard", "Father board", "Childboard"],
                        Answer = "Motherboard",
                    },

                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which is not a computer classification?",
                        Options = ["mainframe", "maxframe", "mini", "notebook"],
                        Answer = "maxframe",
                    },
                    new()
                    {
                        StrQuestion = "The control unit of a microprocessor",
                        Options = ["Stores data in the memory", "Accepts input data from keyboard", "Performs arithmetic/logic function", "None of above"],
                        Answer = "None of above",
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is internal memory?",
                        Options = ["Disks", "Pen Drives", "RAM", "CDs"],
                        Answer = "RAM",
                    },
                    new()
                    {
                        StrQuestion = "Which operation is not performed by computer?",
                        Options = ["Inputting", "Processing", "Controlling", "Understanding"],
                        Answer = "Understanding",
                    },
                    new()
                    {
                        StrQuestion = "Floppy disks which are made from flexible plastic material are also called?",
                        Options = ["Hard disks", "High-density disks", "Diskettes", "Templates"],
                        Answer = "Diskettes",
                    },
                    new()
                    {
                        StrQuestion = "The magnetic storage chip used to provide non-volatile direct access storage of data and that have no moving parts are known as",
                        Options = ["Magnetic core memory", "Magnetic tape memory", "Magnetic disk memory", "Magnetic bubble memory"],
                        Answer = "Magnetic bubble memory",
                    },
                    new()
                    {
                        StrQuestion = "A collection of related instructions organized for a common purpose is referred to as",
                        Options = ["File", "Database", "Program", "None of above"],
                        Answer = "Program",
                    },
                    new()
                    {
                        StrQuestion = "Plotter accuracy is measured in terms of repeatability and",
                        Options = ["Buffer size", "Resolution", "Vertical dimensions", "Intelligence"],
                        Answer = "Resolution",
                    },
                    new()
                    {
                        StrQuestion = "Computer instructions written with the use of English words instead of binary machine code is called",
                        Options = ["Mnemonics", "Symbolic code", "Gray codes", "Opcode"],
                        Answer = "Symbolic code",
                    },
                    new()
                    {
                        StrQuestion = "Which language is directly understood by the computer without translation program?",
                        Options = ["Machine language", "Assembly language", "High level language", "None of above"],
                        Answer = "Machine language",
                    },
                    new()
                    {
                        StrQuestion = "On which aspect the analog computers are better than digital?",
                        Options = ["Speed", "Accuracy", "Reliability", "Automatic"],
                        Answer = "Speed",
                    },
                    new()
                    {
                        StrQuestion = "Which of the following processors use RISC technology?",
                        Options = ["486dx", "Power PC", "486sx", "6340"],
                        Answer = "Power PC",
                    },
                    new()
                    {
                        StrQuestion = "Which of the following machine was not invented by Charles Babbage?",
                        Options = ["Tabulating Machine", "Analytical Engine", "Difference Engine", "Both C and D"],
                        Answer = "Tabulating Machine",
                    },
                    new()
                    {
                        StrQuestion = "How many numbers could ENIAC store in its internal memory?",
                        Options = ["100", "20", "80", "40"],
                        Answer = "20",
                    },
                    new()
                    {
                        StrQuestion = "The subject of cybernetics deals with the science of",
                        Options = ["Genetics", "Control and communication", "Molecular biology", "Biochemistry"],
                        Answer = "Control and communication",
                    },
                    new()
                    {
                        StrQuestion = "Why ABC is considered electro-mechanical computer?",
                        Options = ["Because it was invented before electronic computers were developed", "Because there are wheels, drums, bars to rotate and move to produce result", "Because they use the flow of electrons in different component", "None of above"],
                        Answer = "Because there are wheels, drums, bars to rotate and move to produce result",
                    },
                    new()
                    {
                        StrQuestion = "Binary circuit elements have",
                        Options = ["One stable state", "Two stable state", "Three stable state", "None of above"],
                        Answer = "Two stable state",
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is used for manufacturing chips?",
                        Options = ["Control bus", "Control unit", "Parity unit", "Semiconductor"],
                        Answer = "Semiconductor",
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is not a micro computer?",
                        Options = ["Laptop PCs", "Tablet PCs", "Desktop PCs", "None of above"],
                        Answer = "None of above",
                    },
                    new()
                    {
                        StrQuestion = "The value of each bead in earth is",
                        Options = ["1", "3", "5", "7"],
                        Answer = "1",
                    },
                ]
            },


            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "When did John Napier develop logarithm?",
                        Options = ["1416", "1614", "1641", "1804"],
                        Answer = "1614",
                    },
                    new()
                    {
                        StrQuestion = "Which of the following terms is the most closely related to main memory?",
                        Options = ["Non volatile", "Permanent", "Control unit", "Temporary"],
                        Answer = "Temporary",
                    },
                    new()
                    {
                        StrQuestion = "Which was the world’s first minicomputer and when was it introduced?",
                        Options = ["PDP-I, 1958", "IBM System/36, 1960", "PDP-II, 1961", "VAX 11/780, 1962"],
                        Answer = "PDP-I, 1958",
                    },
                    new()
                    {
                        StrQuestion = "A group of magnetic tapes, videos or terminals usually under the control of one master is",
                        Options = ["Cylinder", "Surface", "Track", "Cluster"],
                        Answer = "Cluster",
                    },
                    new()
                    {
                        StrQuestion = "The word length of a computer is measured in",
                        Options = ["Bytes", "Millimeters", "Meters", "Bits"],
                        Answer = "Bits",
                    },
                    new()
                    {
                        StrQuestion = "What type of memory is not directly addressable by the CPU and requires special software called EMS (expanded memory specification)?",
                        Options = ["Extended", "Expanded", "Base", "Conventional"],
                        Answer = "Expanded",
                    },
                    new()
                    {
                        StrQuestion = "Which unit holds data permanently?",
                        Options = ["Input unit", "Secondary storage unit", "Output Unit", "Primary Memory Unit"],
                        Answer = "Secondary storage unit",
                    },
                    new()
                    {
                        StrQuestion = "Before a disk can be used to store data. It must be_______",
                        Options = ["Formatted", "Reformatted", "Addressed", "None of the above"],
                        Answer = "Formatted",
                    },
                    new()
                    {
                        StrQuestion = "Computer system comprises of major units",
                        Options = ["input unit, output unit, control unit", "input unit, output unit, control unit and storage", "input unit, output unit, central processing unit and storage unit", "input, output and storage units"],
                        Answer = "input unit, output unit, central processing unit and storage unit",
                    },
                    new()
                    {
                        StrQuestion = "The first general purpose electronic digital computer in the world was",
                        Options = ["UNIVAC", "EDVAC", "ENIAC", "All of above"],
                        Answer = "ENIAC",
                    },
                    new()
                    {
                        StrQuestion = "Signals can be analog or digital and a computer that processes both types of signals is known as",
                        Options = ["Analog computer", "Digital Computer", "Hybrid Computer", "Mainframe Computer"],
                        Answer = "Hybrid Computer",
                    },
                    new()
                    {
                        StrQuestion = "High level language is also called",
                        Options = ["Problem oriented language", "Business oriented language", "Mathematically oriented language", "All of the above"],
                        Answer = "All of the above",
                    },
                    new()
                    {
                        StrQuestion = "Human beings are referred to as Homosapiens, which device is called Silico Sapiens?",
                        Options = ["Monitor", "Hardware", "Robot", "Computer"],
                        Answer = "Computer",
                    },
                    new()
                    {
                        StrQuestion = "Which of the following file organization is most efficient for a file with a high degree of file activity?",
                        Options = ["Sequential", "ISAM", "VSAM", "B-Tree Index"],
                        Answer = "Sequential",
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is associated with error detector?",
                        Options = ["Odd parity bit", "Even parity bit", "Both of the above", "None of above"],
                        Answer = "Both of the above",
                    },
                    new()
                    {
                        StrQuestion = "Magnetic tape can serve as",
                        Options = ["Secondary storage media", "Output media", "Input media", "All of the above"],
                        Answer = "All of the above",
                    },
                    new()
                    {
                        StrQuestion = "Which company is the biggest player in the microprocessor industry?",
                        Options = ["Motorola", "IBM", "Intel", "AMD"],
                        Answer = "Intel",
                    },
                    new()
                    {
                        StrQuestion = "The first digital computer built with IC chips was known as",
                        Options = ["IBM 7090", "Apple ? 1", "IBM System / 360", "VAX-10"],
                        Answer = "IBM System / 360",
                    },
                    new()
                    {
                        StrQuestion = "EBCDIC can code up to how many different characters?",
                        Options = ["256", "16", "32", "64"],
                        Answer = "256",
                    },
                    new()
                    {
                        StrQuestion = "MICR stands for",
                        Options = ["Magnetic Ink Character Reader", "Magnetic Ink Code Reader", "Magnetic Ink Cases Reader", "None"],
                        Answer = "Magnetic Ink Character Reader",
                    },
                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Number crunchier is the informal name for",
                        Options = ["Mini computer", "Super computer", "Microcomputer", "Mainframe computer"],
                        Answer = "Super computer",
                    },
                    new()
                    {
                        StrQuestion = "RATS stand for",
                        Options = ["Regression Analysis Time Series", "Regression Analysis Time Sharing", "Real Analysis Series", "All of above"],
                        Answer = "Regression Analysis Time Series",
                    },
                    new()
                    {
                        StrQuestion = "Which technology is used in Compact disks?",
                        Options = ["Mechanical", "Electrical", "Electro Magnetic", "Laser"],
                        Answer = "Laser",
                    },
                    new()
                    {
                        StrQuestion = "Different components of the motherboard of a PC unit are linked together by sets of parallel electrical conducting lines. What are these lines called?",
                        Options = ["Conductors", "Buses", "Connectors", "Consecutive"],
                        Answer = "Buses",
                    },
                    new()
                    {
                        StrQuestion = "Which is the first electronic digital computer?",
                        Options = ["ENIAC", "MARK I", "Z3", "ABC"],
                        Answer = "ENIAC",
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is a storage device?",
                        Options = ["Tape", "Hard Disk", "Floppy Disk", "All of the above"],
                        Answer = "All of the above",
                    },
                    new()
                    {
                        StrQuestion = "The metal disks, which are permanently housed in, sealed and contamination free containers are called",
                        Options = ["Hard disks", "Floppy disk", "Winchester disk", "Flexible disk"],
                        Answer = "Winchester disk",
                    },
                    new()
                    {
                        StrQuestion = "A computer program that converts an entire program into machine language is called a/an",
                        Options = ["Interpreter", "Simulator", "Compiler", "Commander"],
                        Answer = "Compiler",
                    },
                    new()
                    {
                        StrQuestion = "Intel corporation produces chips for which computers?",
                        Options = ["IBM PCs", "Apple/Macintosh PCs", "Both of above", "None of above"],
                        Answer = "Both of above",
                    },
                    new()
                    {
                        StrQuestion = "The first microprocessor built by the Intel corporation was called",
                        Options = ["8008", "8080", "4004", "8800"],
                        Answer = "4004",
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is not a class of computers based on size?",
                        Options = ["Mainframe Computers", "Mini Computers", "Micro Computers", "Super Computers"],
                        Answer = "Super Computers",
                    },
                    new()
                    {
                        StrQuestion = "Who invented EDSAC?",
                        Options = ["John v. Neumann", "J.p. Eckert and John Mauchley", "Maurice Wilkes", "Howard Aiken"],
                        Answer = "Maurice Wilkes",
                    },
                    new()
                    {
                        StrQuestion = "EEPROM stands for",
                        Options = ["Electrically Erasable Programmable Read Only Memory", "Electronic Erasable Programmable Read Only Memory", "Easily Erasable Programmable Read Only Memory", "Easily Erasable Programmable Read Only Memory"],
                        Answer = "Electrically Erasable Programmable Read Only Memory",
                    },
                    new()
                    {
                        StrQuestion = "Which of the following is a class of computers based on model?",
                        Options = ["Digital Computer", "Hybrid Computers", "Analog Computers", "AT Computers"],
                        Answer = "Digital Computer",
                    },
                    new()
                    {
                        StrQuestion = "What are the computers called that performs calculations and comparisons usually in the binary numbering system?",
                        Options = ["Analog Computers", "Digital Computers", "Hybrid Computers", "None of above"],
                        Answer = "Digital Computers",
                    },
                    new()
                    {
                        StrQuestion = "ASCII stands for",
                        Options = ["American Standard Code for Information Interchange", "American Scientific Code for International Interchange", "American Standard Code for Intelligence Interchange", "American Scientific Code for Information Interchange"],
                        Answer = "American Standard Code for Information Interchange",
                    },
                    new()
                    {
                        StrQuestion = "The data recording format in most of the modern magnetic tape is",
                        Options = ["7-bit ASCII", "7-bit EBCDIC", "8-bit ASCII", "8-bit EBCDIC"],
                        Answer = "8-bit EBCDIC",
                    },
                    new()
                    {
                        StrQuestion = "Why ABC computer is called so?",
                        Options = ["Because it was developed by Atanasoff and Berry", "Because it was thought to be the first computer so named with first alphabets of English", "Both of above are the reason to name the computer ABC", "None of above are true"],
                        Answer = "Because it was developed by Atanasoff and Berry",
                    },
                    new()
                    {
                        StrQuestion = "Who designed the first electronics computer ? ENIAC/",
                        Options = ["Von Neumann", "Joseph M Jacquard", "J. P. Eckert and J. W. Mauchly", "All of above"],
                        Answer = "J. P. Eckert and J. W. Mauchly",
                    },
                    new()
                    {
                        StrQuestion = "Central Processing Unit is combination of",
                        Options = ["Control and storage", "Control and output unit", "Arithmetic logic and input unit", "Arithmetic logic and control unit"],
                        Answer = "Arithmetic logic and control unit",
                    },
                ]
            },

            new("CSC101")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "A set of rods where numbers were carved and used for multiplication and division aids is known as",
                        Options = ["Pascaline", "Napier’s Bones", "Stepped Reckoner", "Slide Rule"],
                        Answer = "Napier’s Bones",
                    },

                    new()
                    {
                        StrQuestion = "Seek time is",
                        Options = ["time to position the head over proper track", "time to position the head over proper sector", "time to position the head over proper cylinder", "none of above"],
                        Answer = "time to position the head over proper track",
                    },

                    new()
                    {
                        StrQuestion = "Tape speed is measured in",
                        Options = ["Feet per second", "Inch per second", "Meter per second", "Centimeter per second"],
                        Answer = "Feet per second",
                    },

                    new()
                    {
                        StrQuestion = "Punched cards were first introduced by",
                        Options = ["Powers", "Pascal", "Jacquard", "Herman Hollerith"],
                        Answer = "Herman Hollerith",
                    },

                    new()
                    {
                        StrQuestion = "Which computer support coprocessors?",
                        Options = ["XT computer", "AT computers", "None of these", "Both of these"],
                        Answer = "Both of these",
                    },

                    new()
                    {
                        StrQuestion = "A floppy disk contains",
                        Options = ["Circular tracks only", "Sectors only", "Both circular tracks and sectors", "None of the above"],
                        Answer = "Both circular tracks and sectors",
                    },

                    new()
                    {
                        StrQuestion = "The capacity of 3.5 inch floppy disk is",
                        Options = ["1.40 MB", "1.44 GB", "1.40 GB", "1.44 MB"],
                        Answer = "1.44 MB",
                    },

                    new()
                    {
                        StrQuestion = "The contribution of Konrad Zuse was long ignored because",
                        Options = ["He made the computers secretly", "his computers were very complicated and it took time for the people to recognize its power", "of political reasons. He was German.", "All of the above"],
                        Answer = "All of the above",
                    },

                    new()
                    {
                        StrQuestion = "Any method for controlling access to or use of memory is known",
                        Options = ["Memory map", "Memory protection", "Memory management", "Memory instruction"],
                        Answer = "Memory management",
                    },

                    new()
                    {
                        StrQuestion = "In what respect computers are superior to human beings?",
                        Options = ["Diligence", "Intelligence", "Both of above", "None of above"],
                        Answer = "Diligence",
                    },

                    new()
                    {
                        StrQuestion = "Com in Latin is",
                        Options = ["intensifying prefix", "intensifying suffix", "a term that means to reckon", "None of above"],
                        Answer = "intensifying prefix",
                    },

                    new()
                    {
                        StrQuestion = "The system unit of a personal computer typically contains all of the following except:",
                        Options = ["Microprocessor", "Disk controller", "Serial interface", "Modem"],
                        Answer = "Modem",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is related to fifth generation computers?",
                        Options = ["Knowledge information processing system", "Very large scale integration (VLSI)", "Both of above", "Only b"],
                        Answer = "Both of above",
                    },

                    new()
                    {
                        StrQuestion = "The process of starting or restarting a computer system by loading instructions from a secondary storage device into the computer memory is called",
                        Options = ["Duping", "Booting", "Padding", "CPS"],
                        Answer = "Booting",
                    },

                    new()
                    {
                        StrQuestion = "MSI stands for",
                        Options = ["Medium Scale Integrated Circuits", "Medium System Integrated Circuits", "Medium Scale Intelligent Circuit", "Medium System Intelligent Circuit"],
                        Answer = "Medium Scale Integrated Circuits",
                    },

                    new()
                    {
                        StrQuestion = "A Pixel is _________",
                        Options = ["A computer program that draws picture", "A picture stored in secondary memory", "The smallest resolvable part of a picture", "None of these"],
                        Answer = "The smallest resolvable part of a picture",
                    },

                    new()
                    {
                        StrQuestion = "A/n _____ Device is any device that provides information, which is sent to the CPU",
                        Options = ["Input", "Output", "CPU", "Memory"],
                        Answer = "Input",
                    },

                    new()
                    {
                        StrQuestion = "What was the nick name of the computer used by the Americans in 1952 for their H-bomb project?",
                        Options = ["ENIAC", "EDSAC", "MANIAC", "UNIVAC"],
                        Answer = "MANIAC",
                    },

                    new()
                    {
                        StrQuestion = "Which is the type of memory for information that does not change on your computer?",
                        Options = ["RAM", "ROM", "ERAM", "RW / RAM"],
                        Answer = "ROM",
                    },

                    new()
                    {
                        StrQuestion = "LSI, VLSI & ULSI chips were used in which generation?",
                        Options = ["First", "Second", "Third", "Fourth"],
                        Answer = "Fourth",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is the largest manufacturer of Hard Disk Drives?",
                        Options = ["IBM", "Seagate", "Microsoft", "3M"],
                        Answer = "Seagate",
                    },

                    new()
                    {
                        StrQuestion = "Networking such as LAN, MAN started from",
                        Options = ["First generation", "Second generation", "Third generation", "Fourth generation"],
                        Answer = "Fourth generation",
                    },

                    new()
                    {
                        StrQuestion = "Which characteristic of computer distinguishes it from electronic calculators?",
                        Options = ["Accuracy", "Storage", "Versatility", "Automatic"],
                        Answer = "Versatility",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following registers is used to keep track of address of the memory location where the next instruction is located?",
                        Options = ["Memory address register", "Memory data register", "Instruction register", "Program counter"],
                        Answer = "Program counter",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not the classification of computers based on application?",
                        Options = ["Electronic Computers", "Analog Computers", "Digital Computers", "Hybrid Computers"],
                        Answer = "Electronic Computers",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not a type of Software?",
                        Options = ["System Software", "Application Software", "Utility Software", "Entertainment Software"],
                        Answer = "Entertainment Software",
                    },

                    new()
                    {
                        StrQuestion = "Who invented the high level language C?",
                        Options = ["Dennis M. Ritchie", "Niklaus Writh", "Seymour Papert", "Donald Kunth"],
                        Answer = "Dennis M. Ritchie",
                    },

                    new()
                    {
                        StrQuestion = "What do you call the programs that are used to find out possible faults and their causes?",
                        Options = ["Operating system extensions", "Cookies", "Diagnostic software", "Boot diskettes"],
                        Answer = "Diagnostic software",
                    },

                    new()
                    {
                        StrQuestion = "Which computer memory is used for storing programs and data currently being processed by the CPU?",
                        Options = ["Mass memory", "Internal memory", "Non-volatile memory", "PROM"],
                        Answer = "Internal memory",
                    },

                    new()
                    {
                        StrQuestion = "Which of the following code used in present day computing was developed by IBM Corporation?",
                        Options = ["ASCII", "Hollerith Code", "Baudot Code", "EBCDIC Code"],
                        Answer = "EBCDIC Code",
                    },

                ]
            },

            #endregion

            //THIS IS THE Beginning OF CSC201 QUESTIONS    *******            ******************************** THIS IS THE ENDING OF CSC201 QUESTIONS 
            //THIS IS THE Beginning OF CSC201 QUESTIONS    *******            ******************************* THIS IS THE ENDING OF CSC201 QUESTIONS 
            //THIS IS THE Beginning OF CSC201 QUESTIONS    *************************************************** THIS IS THE ENDING OF CSC201 QUESTIONS 
#region "CSC201"
            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which of these is not a core datatype?",
                        Options =  ["Lists", "Dictionary", "Tuples", "Class" ],
                        Answer = "Class",
                        Explanation = "Class is a user-defined datatype, not a core Python datatype."
                    },

                    new()
                    {
                        StrQuestion = "Given a function that does not return any value, what value is thrown by it by default when executed in the shell?",
                        Options = [ "int", "bool", "void", "None"],
                        Answer = "None",
                        Explanation = "Python functions that don't explicitly return a value will return None by default."
                    },

                    new()
                    {
                        StrQuestion = "Following set of commands are executed in shell, what will be the output?<br />>>>str = 'hello'<br />>>>str[:2]",
                        Options = [ "he", "lo", "olleh", "hello"],
                        Answer = "he",
                        Explanation = "The slice str[:2] retrieves the first two characters of the string, i.e., 'he'."
                    },

                    new()
                    {
                        StrQuestion = "Which of the following will run without errors?",
                        Options = ["round(6352.898, 2)", "round()", "round(7463.123,2,1)"],
                        Answer = "round(6352.898, 2)",
                        Explanation = "The round() function can take one or two arguments. The first argument is a number to round, and the second is an optional precision value."
                    },
                ],


            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the return type of function id()?",
                        Options = [ "int", "float", "bool", "dict" ],
                        Answer = "int",
                        Explanation = "The id() function returns an integer representing the identity of an object."
                    },

                    new()
                    {
                        StrQuestion  = "In Python, consider the following operation to make sure x has an integer value:<br />>>>x = 13 ? 2<br />objective is to make sure x has an integer value, select all that apply (python 3.xx)",
                        Options = [ "x = 13 // 2", "x = int(13 / 2)", "x = 13 / 2", "x = 13 % 2"],
                        Answer = "x = 13 // 2, x = int(13 / 2)",
                        Explanation = "// performs integer division, and int() can cast a float to an integer."
                    },

                    new()
                    {
                        StrQuestion = "What error occurs when you execute?<br />apple = mango",
                        Options = [ "SyntaxError", "NameError", "ValueError", "TypeError"],
                        Answer = "NameError",
                        Explanation = "mango is not defined, so a NameError occurs."
                    },

                    new()
                    {
                        StrQuestion = "Carefully observe the code and give the answer.<br />```python<br />def example(a):<br />   a = a + '2'<br />   a = a * 2<br />   return a<br />>>> example('hello')```",
                        Options = [ "IndentationError", "cannot perform mathematical operation on strings", "hello2", "hello2hello2"],
                        Answer = "IndentationError",
                        Explanation = "The function definition is missing proper indentation, which results in an IndentationError."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What datatype is the object below?<br />L = [1, 23, 'hello', 1]",
                        Options = [ "List", "dictionary", "array", "tuple"],
                        Answer = "List",
                        Explanation = "The object L is a list, as denoted by the square brackets."
                    },

                    new()
                    {
                        StrQuestion = "In order to store values in terms of key and value we use what core datatype?",
                        Options = [ "List", "tuple", "class", "dictionary"],
                        Answer = "dictionary",
                        Explanation = "A dictionary stores values in key-value pairs."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the average value of the code executed below?<br />>>>grade1 = 80<br />>>>grade2 = 90<br />>>>average = (grade1 + grade2) / 2",
                        Options = [ "85", "85.0", "95", "95.0"],
                        Answer = "85.0",
                        Explanation = "The result is a float since division in Python 3 always returns a float."
                    },

                    new()
                    {
                        StrQuestion = "Select all options that print `hello-how-are-you`",
                        Options = [ "print('hello' , 'how' , 'are' , 'you')", "print('hello' , 'how' , 'are' , 'you' + '-' * 4)", "print('hello-' + 'how-are-you')", "print('hello' + '-' + 'how' + '-' + 'are' + '-' + 'you')"],
                        Answer = "print('hello-' + 'how-are-you'), print('hello' + '-' + 'how' + '-' + 'are' + '-' + 'you')",
                        Explanation = "Both options correctly concatenate strings to produce the desired output."
                    },

                    new()
                    {
                        StrQuestion = "What is the return value of trunc()?",
                        Options = [ "int", "bool", "float", "None"],
                        Answer = "int",
                        Explanation = "math.trunc() returns the truncated integer part of a float."
                    },

                    new()
                    {
                        StrQuestion = "Which is the correct operator for power(x^y)?",
                        Options = [ "X^y", "X**y", "X^^y", "None of the mentioned"],
                        Answer = "X**y",
                        Explanation = "In Python, the power operator is x**y, i.e., 2**3 = 8."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which one of these is floor division?",
                        Options = [ "/", "//", "%", "None of the mentioned"],
                        Answer = "//",
                        Explanation = "Floor division is performed using the // operator. It divides and rounds down to the nearest integer."
                    },

                    new()
                    {
                        StrQuestion = "What is the order of precedence in Python?",
                        Options = [ "i) Parentheses ii) Exponential iii) Division iv) Multiplication v) Addition vi) Subtraction", "ii) i) iii) iv) v) vi", "ii) i) iv) iii) v) vi", "i) ii) iii) iv) vi) v"],
                        Answer = "i) ii) iii) iv) v) vi",
                        Explanation = "The order of precedence is Parentheses, Exponential, Division, Multiplication, Addition, Subtraction. This follows the PEDMAS rule."
                    },

                    new()
                    {
                        StrQuestion = "What is the answer of this expression, 22 % 3?",
                        Options = [ "7", "1", "0", "5"],
                        Answer = "1",
                        Explanation = "The modulus operator (%) gives the remainder. 22 % 3 gives a remainder of 1."
                    },

                    new()
                    {
                        StrQuestion = "You can perform mathematical operations on strings?",
                        Options = [ "True", "False"],
                        Answer = "False",
                        Explanation = "You cannot perform mathematical operations on strings even if they look like integers."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Operators with the same precedence are evaluated in which manner?",
                        Options = [ "Left to Right", "Right to Left"],
                        Answer = "Left to Right",
                        Explanation = "Operators with the same precedence are evaluated from left to right, unless otherwise specified."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of this expression, 3*1**3?",
                        Options = [ "27", "9", "3", "1"],
                        Answer = "3",
                        Explanation = "First, 1**3 is evaluated due to the higher precedence of the exponentiation operator. Then, 3*1 results in 3."
                    },

                    new()
                    {
                        StrQuestion = "Which one of the following have the same precedence?",
                        Options = [ "Addition and Subtraction", "Multiplication and Division", "a and b", "None of the mentioned"],
                        Answer = "a and b",
                        Explanation = "Addition and Subtraction, as well as Multiplication and Division, have the same precedence."
                    },

                    new()
                    {
                        StrQuestion = "Int(x) means variable x is converted to integer.",
                        Options = [ "True", "False"],
                        Answer = "True",
                        Explanation = "The int() function converts a variable to an integer."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which one of the following have the highest precedence in the expression?",
                        Options = [ "Exponential", "Addition", "Multiplication", "Parentheses"],
                        Answer = "Parentheses",
                        Explanation = "Parentheses have the highest precedence in any expression, and they are evaluated first."
                    },

                    new()
                    {
                        StrQuestion = "Is Python case sensitive when dealing with identifiers?",
                        Options = [ "yes", "no", "sometimes only", "none of the mentioned"],
                        Answer = "yes",
                        Explanation = "Case is always significant in Python."
                    },

                    new()
                    {
                        StrQuestion = "What is the maximum possible length of an identifier?",
                        Options = [ "31 characters", "63 characters", "79 characters", "none of the mentioned"],
                        Answer = "none of the mentioned",
                        Explanation = "Identifiers can be of any length in Python."
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is invalid?",
                        Options = [ "_a = 1", "__a = 1", "__str__ = 1", "none of the mentioned"],
                        Answer = "none of the mentioned",
                        Explanation = "All the statements are valid identifiers, but they may reduce readability."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which of the following is an invalid variable?",
                        Options = [ "my_string_1", "1st_string", "foo", "_"],
                        Answer = "1st_string",
                        Explanation = "Variable names cannot start with a number."
                    },

                    new()
                    {
                        StrQuestion = "Why are local variable names beginning with an underscore discouraged?",
                        Options = [ "they are used to indicate private variables of a class", "they confuse the interpreter", "they are used to indicate global variables", "they slow down execution"],
                        Answer = "they are used to indicate private variables of a class",
                        Explanation = "Leading underscores in Python are used to indicate that a variable is intended to be private."
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not a keyword?",
                        Options = [ "eval", "assert", "nonlocal", "pass"],
                        Answer = "eval",
                        Explanation = "eval is a function, not a keyword, and can be used as a variable name."
                    },

                    new()
                    {
                        StrQuestion = "All keywords in Python are in",
                        Options = [ "lower case", "UPPER CASE", "Capitalized", "none"],
                        Answer = "none",
                        Explanation = "Most keywords are in lowercase, but True, False, and None are capitalized."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which of the following is true for variable names in Python?",
                        Options = [ "unlimited length", "all private members must have leading and trailing underscores", "underscore and ampersand are the only two special characters allowed", "none" ],
                        Answer = "unlimited length",
                        Explanation = "Variable names can be of any length in Python."
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is an invalid statement?",
                        Options = [ "abc = 1,000,000", "a b c = 1000 2000 3000", "a,b,c = 1000, 2000, 3000", "a_b_c = 1,000,000"],
                        Answer = "a b c = 1000 2000 3000",
                        Explanation = "Spaces are not allowed in variable names."
                    },

                    new()
                    {
                        StrQuestion = "Which of the following cannot be a variable?",
                        Options = [ "__init__", "in", "it", "on"],
                        Answer = "in",
                        Explanation = "in is a keyword in Python, so it cannot be used as a variable."
                    },

                    new()
                    {
                        StrQuestion = "Which module in Python supports regular expressions?",
                        Options = [ "re", "regex", "pyregex", "none of the mentioned"],
                        Answer = "re",
                        Explanation = "The re module is part of the standard library and can be imported using: import re."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Which of the following creates a pattern object?",
                        Options = [ "re.create(str)", "re.regex(str)", "re.compile(str)", "re.assemble(str)"],
                        Answer = "re.compile(str)",
                        Explanation = "The re.compile() function compiles a string into a pattern object."
                    },

                    new()
                    {
                        StrQuestion = "What does the function re.match do?",
                        Options = [ "matches a pattern at the start of the string", "matches a pattern at any position in the string", "such a function does not exist", "none of the mentioned"],
                        Answer = "matches a pattern at the start of the string",
                        Explanation = "The re.match() function checks for a pattern only at the beginning of the string."
                    },

                    new()
                    {
                        StrQuestion = "What does the function re.search do?",
                        Options = [ "matches a pattern at the start of the string", "matches a pattern at any position in the string", "such a function does not exist", "none of the mentioned"],
                        Answer = "matches a pattern at any position in the string",
                        Explanation = "The re.search() function searches for the pattern anywhere in the string."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? sentence = 'we are humans' matched = re.match(r'(.*) (.*?) (.*)', sentence) print(matched.groups())",
                        Options = [ "('we' , ' are' , 'humans' )", "(we, are, humans)", "('we' , ' humans' )", "'we are humans'"],
                        Answer = "('we' , ' are' , 'humans' )",
                        Explanation = "The re.match() function returns all the matched subgroups."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following? sentence = 'we are humans' matched = re.match(r'(.*) (.*?) (.*)', sentence) print(matched.group())",
                        Options = [ "('we' , ' are' , 'humans' )", "(we, are, humans)", "('we' , ' humans' )", "'we are humans'"],
                        Answer = "'we are humans'",
                        Explanation = "The group() function returns the entire match."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? sentence = 'we are humans' matched = re.match(r'(.*) (.*?) (.*)', sentence) print(matched.group(2))",
                        Options = [ "'are'", "'we'", "'humans'", "'we are humans'"],
                        Answer = "'are'",
                        Explanation = "The group(2) function returns the second matched subgroup."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? sentence = 'horses are fast' regex = re.compile('(?P<animal>\\w+) (?P<verb>\\w+) (?P<adjective>\\w+)') matched = re.search(regex, sentence) print(matched.groupdict())",
                        Options = [ "{'animal' : 'horses' , 'verb' : 'are' , 'adjective' : 'fast'}", "('horses' , 'are' , 'fast')", "'horses are fast'", "'are'"],
                        Answer = "{'animal' : 'horses' , 'verb' : 'are' , 'adjective' : 'fast'}",
                        Explanation = "The groupdict() function returns a dictionary of all the matched groups."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? sentence = 'horses are fast' regex = re.compile('(?P<animal>\\w+) (?P<verb>\\w+) (?P<adjective>\\w+)') matched = re.search(regex, sentence) print(matched.groups())",
                        Options = [ "{'animal' : 'horses' , 'verb' : 'are' , 'adjective' : 'fast'}", "('horses' , 'are' , 'fast')", "'horses are fast'", "'are'"],
                        Answer = "('horses' , 'are' , 'fast')",
                        Explanation = "The groups() function returns all the matched subgroups."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following? sentence = 'horses are fast' regex = re.compile('(?P<animal>\\w+) (?P<verb>\\w+) (?P<adjective>\\w+)') matched = re.search(regex, sentence) print(matched.group(2))",
                        Options = [ "{'animal' : 'horses' , 'verb' : 'are' , 'adjective' : 'fast'}", "('horses' , 'are' , 'fast')", "'horses are fast'", "'are'"],
                        Answer = "'are'",
                        Explanation = "The group(2) function returns the second matched subgroup."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of print 0.1 + 0.2 == 0.3?",
                        Options = [ "True", "False", "Machine dependent", "Error"],
                        Answer = "False",
                        Explanation = "Due to floating-point precision issues in binary representation, 0.1 + 0.2 is not exactly equal to 0.3."
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is not a complex number?",
                        Options = [ "k = 2 + 3j", "k = complex(2, 3)", "k = 2 + 3l", "k = 2 + 3J"],
                        Answer = "k = 2 + 3l",
                        Explanation = "In Python, complex numbers are represented using 'j' or 'J', not 'l'."
                    },

                    new()
                    {
                        StrQuestion = "What is the type of inf?",
                        Options = [ "Boolean", "Integer", "Float", "Complex"],
                        Answer = "Float",
                        Explanation = "In Python, 'inf' is a special floating-point value representing positive infinity."
                    },

                    new()
                    {
                        StrQuestion = "What does ~4 evaluate to?",
                        Options = [ "-5", "-4", "-3", "+3"],
                        Answer = "-5",
                        Explanation = "The '~' operator is a bitwise negation, so ~4 = -(4+1) = -5."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What does ~~~~~~5 evaluate to?",
                        Options = [ "+5", "-11", "+11", "-5"],
                        Answer = "-11",
                        Explanation = "The bitwise negation operator (~) inverts the bits, and applying it multiple times alternates the sign."
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is incorrect?",
                        Options = [ "x = 0b101", "x = 0x4f5", "x = 19023", "x = 03964"],
                        Answer = "x = 03964",
                        Explanation = "Python 3 does not support octal literals with leading zeros. The correct format is '0o3964'."
                    },

                    new()
                    {
                        StrQuestion = "What is the result of cmp(3, 1)?",
                        Options = [ "1", "0", "True", "False"],
                        Answer = "1",
                        Explanation = "cmp(x, y) returns 1 if x > y, 0 if x == y, and -1 if x < y."
                    },

                    new()
                    {
                        StrQuestion = "Which of the following is incorrect?",
                        Options = [ "float('inf')", "float('nan')", "float('56'+'78')", "float('12+34')"],
                        Answer = "float('12+34')",
                        Explanation = "'+' cannot be converted to a float, and the string should represent a numeric value directly."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the result of round(0.5) - round(-0.5)?",
                        Options = [ "1.0", "2.0", "0.0", "None of the mentioned"],
                        Answer = "2.0",
                        Explanation = "Python rounds away from zero when the number is exactly halfway between two integers. round(0.5) = 1 and round(-0.5) = -1."
                    },

                    new()
                    {
                        StrQuestion = "What does 3 ^ 4 evaluate to?",
                        Options = [ "81", "12", "0.75", "7"],
                        Answer = "7",
                        Explanation = "The '^' operator is a bitwise XOR operator. 3 ^ 4 results in 7."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = ['ab', 'cd'] <br /> for i in x: <br />&nbsp;&nbsp;&nbsp;&nbsp;i.upper() <br /> print(x)",
                        Options = [ "['ab', 'cd']", "['AB', 'CD']", "[None, None]", "None of the mentioned"],
                        Answer = "['ab', 'cd']",
                        Explanation = "The function upper() does not modify a string in place, it returns a new string which isn’t being stored anywhere."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = ['ab', 'cd'] <br /> for i in x: <br />&nbsp;&nbsp;&nbsp;&nbsp;x.append(i.upper()) <br /> print(x)",
                        Options = [ "['AB', 'CD']", "['ab', 'cd', 'AB', 'CD']", "['ab', 'cd']", "None of the mentioned"],
                        Answer = "None of the mentioned",
                        Explanation = "The loop does not terminate as new elements are being added to the list in each iteration."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> i = 1 <br /> while True: <br />&nbsp;&nbsp;&nbsp;&nbsp; if i%3 == 0: <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; break <br />&nbsp;&nbsp;&nbsp;&nbsp;print(i) <br />&nbsp;&nbsp;&nbsp;&nbsp;i += 1",
                        Options = [ "1 2", "1 2 3", "Error", "None of the mentioned"],
                        Answer = "1 2",
                        Explanation = "The loop prints '1' and '2' before breaking as i becomes 3, which is divisible by 3."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> i = 1 <br /> while True: <br />&nbsp;&nbsp;&nbsp;&nbsp; if i%0O7 == 0:  <br />&nbsp;&nbsp;&nbsp;&nbsp;break <br />&nbsp;&nbsp;&nbsp;&nbsp;print(i) <br />&nbsp;&nbsp;&nbsp;&nbsp;i += 1",
                        Options = [ "1 2 3 4 5 6", "1 2 3 4 5 6 7", "Error", "None of the mentioned"],
                        Answer = "1 2 3 4 5 6",
                        Explanation = "Control exits the loop when i becomes 7 (octal 7 is 7 in decimal)."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> i = 5 <br /> while True: <br />&nbsp;&nbsp;&nbsp;&nbsp;if i%0O11 == 0: <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;break <br />&nbsp;&nbsp;&nbsp;&nbsp;print(i) <br />&nbsp;&nbsp;&nbsp;&nbsp; i += 1",
                        Options = [ "5 6 7 8 9 10", "5 6 7 8", "5 6", "Error"],
                        Answer = "5 6 7 8",
                        Explanation = "0O11 is an octal number (9 in decimal). The loop runs until i reaches 9."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> i = 5 <br /> while True: <br />&nbsp;&nbsp;&nbsp;&nbsp;if i%0O9 == 0: <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;break <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; print(i) <br />&nbsp;&nbsp;&nbsp;&nbsp;i += 1",
                        Options = [ "5 6 7 8", "5 6 7 8 9", "5 6 7 8 9 10 11 12 13 14 15 ….", "Error"],
                        Answer = "Error",
                        Explanation = "9 isn’t allowed in an octal number."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> i = 1 <br /> while True: <br /> if i%2 == 0: <br /> break <br /> print(i) <br /> i += 2",
                        Options = [ "1", "1 2", "1 2 3 4 5 6 …", "1 3 5 7 9 11 …"],
                        Answer = "1 3 5 7 9 11 …",
                        Explanation = "The loop never terminates since i is never even, it prints odd numbers."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> i = 2 <br /> while True: <br /> if i%3 == 0: <br /> break <br /> print(i) <br /> i += 2",
                        Options = [ "2 4 6 8 10 …", "2 4", "2 3", "Error"],
                        Answer = "2 4",
                        Explanation = "The loop prints '2' and '4' before i reaches '6', which is divisible by 3."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> i = 1 <br /> while False: <br /> if i%2 == 0: <br /> break <br /> print(i) <br /> i += 2",
                        Options = [ "1", "1 3 5 7 …", "1 2 3 4 …", "None of the mentioned"],
                        Answer = "None of the mentioned",
                        Explanation = "Control doesn’t enter the loop because the condition is False."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> True = False <br /> while True: <br /> print(True) <br /> break",
                        Options = [ "True", "False", "None", "None of the mentioned"],
                        Answer = "None of the mentioned",
                        Explanation = "SyntaxError: True is a keyword and its value cannot be changed."
                    }

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> i = 0 <br /> while i < 5: <br />&nbsp;&nbsp;&nbsp;&nbsp; print(i) <br />&nbsp;&nbsp;&nbsp;&nbsp;i += 1 <br />&nbsp;&nbsp;&nbsp;&nbsp;if i == 3: <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;break <br />&nbsp;&nbsp;&nbsp;&nbsp;else: <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;print(0)",
                        Options = [ "0 1 2 0", "0 1 2", "Error", "None of the mentioned"],
                        Answer = "0 1 2",
                        Explanation = "The else part is not executed if control breaks out of the loop."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> i = 0 <br /> while i < 3: <br />&nbsp;&nbsp;&nbsp;&nbsp; print(i) <br />&nbsp;&nbsp;&nbsp;&nbsp; i += 1 <br /> else: <br />&nbsp;&nbsp;&nbsp;&nbsp;print(0)",
                        Options = [ "0 1 2 3 0", "0 1 2 0", "0 1 2", "Error"],
                        Answer = "0 1 2 0",
                        Explanation = "The else part is executed when the condition in the while statement is false."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = \"abcdef\" <br /> while i in x: <br />&nbsp;&nbsp;&nbsp;&nbsp;print(i, end=\" \")",
                        Options = [ "a b c d e f", "abcdef", "i i i i i i …", "Error"],
                        Answer = "Error",
                        Explanation = "NameError: 'i' is not defined."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = \"abcdef\" <br /> i = \"i\" <br /> while i in x: <br />&nbsp;&nbsp;&nbsp;&nbsp;print(i, end=\" \")",
                        Options = [ "No output", "i i i i i i …", "a b c d e f", "abcdef"],
                        Answer = "No output",
                        Explanation = "\"i\" is not in \"abcdef\"."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = \"abcdef\" <br /> i = \"a\" <br /> while i in x: <br />&nbsp;&nbsp;&nbsp;&nbsp;print(i, end = \" \")",
                        Options = [ "No output", "i i i i i i …", "a a a a a a …", "a b c d e f"],
                        Answer = "a a a a a a …",
                        Explanation = "As the value of 'i' or 'x' isn’t changing, the condition will always evaluate to True."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = \"abcdef\" <br /> i = \"a\" <br /> while i in x: <br />&nbsp;&nbsp;&nbsp;&nbsp;print('i', end = \" \")",
                        Options = [ "No output", "i i i i i i …", "a a a a a a …", "a b c d e f"],
                        Answer = "i i i i i i …",
                        Explanation = "As the value of 'i' or 'x' isn’t changing, the condition will always evaluate to True."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = \"abcdef\" <br /> i = \"a\" <br /> while i in x: <br />&nbsp;&nbsp;&nbsp;&nbsp; x = x[:-1] <br />&nbsp;&nbsp;&nbsp;&nbsp;print(i, end = \" \")",
                        Options = [ "i i i i i i", "a a a a a a", "a a a a a", "None of the mentioned"],
                        Answer = "a a a a a a",
                        Explanation = "The string 'x' is being shortened by one character in each iteration."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = \"abcdef\" <br /> i = \"a\" <br /> while i in x[:-1]: <br />&nbsp;&nbsp;&nbsp;&nbsp;print(i, end = \" \")",
                        Options = [ "a a a a a", "a a a a a a", "a a a a a a …", "a"],
                        Answer = "a a a a a a …",
                        Explanation = "String 'x' is not being altered and 'i' is in 'x[:-1]'."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = \"abcdef\" <br /> i = \"a\" <br /> while i in x: <br />&nbsp;&nbsp;&nbsp;&nbsp; x = x[1:] <br />&nbsp;&nbsp;&nbsp;&nbsp;print(i, end = \" \")",
                        Options = [ "a a a a a a", "a", "No output", "Error"],
                        Answer = "a",
                        Explanation = "The string 'x' is being shortened by one character in each iteration."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = \"abcdef\" <br /> i = \"a\" <br /> while i in x[1:]: <br />&nbsp;&nbsp;&nbsp;&nbsp;print(i, end = \" \")",
                        Options = [ "a a a a a a", "a", "No output", "Error"],
                        Answer = "No output",
                        Explanation = "The condition 'i' is not in 'x[1:]'."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = 'abcd' <br /> for i in x: <br />&nbsp;&nbsp;&nbsp;&nbsp;print(i) <br /> x.upper()",
                        Options = [ "a B C D", "a b c d", "A B C D", "Error"],
                        Answer = "a b c d",
                        Explanation = "Changes do not happen in-place, rather a new instance of the string is returned."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = 'abcd' <br /> for i in x: <br />&nbsp;&nbsp;&nbsp;&nbsp;print(i.upper())",
                        Options = [ "a b c d", "A B C D", "a B C D", "Error"],
                        Answer = "A B C D",
                        Explanation = "The instance of the string returned by upper() is being printed."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = 'abcd' <br /> for i in range(x): <br />&nbsp;&nbsp;&nbsp;&nbsp; print(i)",
                        Options = [ "a b c d", "0 1 2 3", "Error", "None of the mentioned"],
                        Answer = "Error",
                        Explanation = "range(str) is not allowed."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = 'abcd' <br /> for i in range(len(x)): <br />&nbsp;&nbsp;&nbsp;&nbsp;print(i)",
                        Options = [ "a b c d", "0 1 2 3", "Error", "None of the mentioned"],
                        Answer = "0 1 2 3",
                        Explanation = "i takes values 0, 1, 2 and 3."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = 'abcd' <br /> for i in range(len(x)): <br />&nbsp;&nbsp;&nbsp;&nbsp; print(i.upper())",
                        Options = [ "a b c d", "0 1 2 3", "Error", "None of the mentioned"],
                        Answer = "Error",
                        Explanation = "Objects of type int have no attribute upper()."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following? <br /> x = 'abcd' <br /> for i in range(len(x)): <br />&nbsp;&nbsp;&nbsp;&nbsp;i.upper() <br />&nbsp;&nbsp;&nbsp;&nbsp;print(x)",
                        Options = [ "a b c d", "0 1 2 3", "Error", "None of the mentioned"],
                        Answer = "Error",
                        Explanation = "Objects of type int have no attribute upper()."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                new()
                    {
                        StrQuestion = "What is the output when following statement is executed ?<br />>>>\"abcd\"[2:]",
                        Options = [ "a) a", "b) ab", "c) cd", "d) dc"],
                        Answer = "c",
                        Explanation = "Slice operation is performed on string."
                    },

                    new()
                    {
                        StrQuestion = "The output of executing string.ascii_letters can also be achieved by:",
                        Options = [ "a) string.ascii_lowercase_string.digits", "b) string.ascii_lowercase+string.ascii_upercase", "c) string.letters", "d) string.lowercase_string.upercase"],
                        Answer = "b",
                        Explanation = "Execute in shell and check."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [


                    new()
                    {
                        StrQuestion = "print 0xA + 0xB + 0xC :",
                        Options = [ "a) 0xA0xB0xC", "b) Error", "c) 0x22", "d) 33"],
                        Answer = "d",
                        Explanation = "0xA and 0xB and 0xC are hexadecimal integer literals representing the decimal values 10,11 and 12 respectively. Their sum is 33."
                    },


                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following code ?<br />class tester:<br />&nbsp;&nbsp;&nbsp;&nbsp;def __init__(self, id):<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;self.id = str(id)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;id=\"224\"<br /> >>>temp = tester(12)<br />>>>print temp.id",
                        Options = [ "a) 224", "b) Error", "c) 12", "d) None"],
                        Answer = "c",
                        Explanation = "id in this case will be the attribute of the class."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following code ?<br />>>>example = \"snow world\"<br />>>>print \"%s\" % example[4:7]",
                        Options = [ "a) wo", "b) world", "c) sn", "d) rl"],
                        Answer = "a",
                        Explanation = "Execute in the shell and verify."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following code ?<br />>>>example = \"snow world\"<br />>>>example[3] = 's'<br />>>>print example",
                        Options = [ "a) snow", "b) snow world", "c) Error", "d) snos world"],
                        Answer = "c",
                        Explanation = "Strings cannot be modified."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following code ?<br />>>>max(\"what are you\")",
                        Options = [ "a) Error", "b) u", "c) t", "d) y"],
                        Answer = "d",
                        Explanation = "Max returns the character with the highest ascii value."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Given a string example=” hello” what is the output of example.count(l)",
                        Options = [ "a) 2", "b) 1", "c) None", "d) 0"],
                        Answer = "a",
                        Explanation = "l occurs twice in hello."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following code ?<br />>>>example = \"helle\"<br />>>>example.find(\"e\")",
                        Options = [ "a) Error", "b) -1", "c) 1", "d) 0"],
                        Answer = "c",
                        Explanation = "returns lowest index."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following code ?<br />>>>example = \"helle\"<br />>>>example.rfind(\"e\")",
                        Options = [ "a) -1", "b) 4", "c) 3", "d) 1"],
                        Answer = "b",
                        Explanation = "returns highest index."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following code ?<br />>>>example=\"helloworld\"<br />>>>example[::-1].startswith(\"d\")",
                        Options = [ "a) dlrowolleh", "b) True", "c) -1", "d) None"],
                        Answer = "b",
                        Explanation = "Starts with checks if the given string starts with the parameter that is passed."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "To concatenate two strings to a third what statements are applicable (multiple answers are allowed) ?",
                        Options = [ "a) s3 = s1 + s2", "b) s3 = s1.add(s2)", "d) s3 = s1 * s2"],
                        Answer = "a",
                        Explanation = "__add__ is another method that can be used for concatenation."
                    },

                    new()
                    {
                        StrQuestion = "What is the output when following statement is executed ?<br />>>>chr(ord('A'))",
                        Options = [ "a) A", "b) B", "c) a", "d) Error"],
                        Answer = "a",
                        Explanation = "Execute in shell to verify."
                    },

                    new()
                    {
                        StrQuestion = "What is the output when following statement is executed ?<br />>>>print(chr(ord('b')+1))",
                        Options = [ "a) a", "b) b", "c) c", "d) A"],
                        Answer = "c",
                        Explanation = "Execute in the shell to verify."
                    },

                    new()
                    {
                        StrQuestion = "Which of the following statement prints hello\\example\\test.txt ?",
                        Options = [ "a) print(“hello\\example\\test.txt” )", "b) print(“hello\\\\example\\\\test.txt” )", "c) print(“hello\\” example\\” test.txt” )", "d) print(“hello” \\example” \\test.txt” )"],
                        Answer = "b",
                        Explanation = "\\ is used to indicate that the next \\ is not an escape sequence."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Suppose s is “\\t\\tWorld\\n” , what is s.strip() ?",
                        Options = [ "a) \\t\\tWorld\\n", "b) \\t\\tWorld\\n", "c) \\t\\tWORLD\\n", "d) World"],
                        Answer = "d",
                        Explanation = "Execute help(string.strip) to find details."
                    },

                    new()
                    {
                        StrQuestion = "The format function returns :",
                        Options = [ "a) Error", "b) int", "c) bool", "d) str"],
                        Answer = "d",
                        Explanation = "Format function returns a string."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of “hello” +1+2+3 ?",
                        Options = [ "a) hello123", "b) hello", "c) Error", "d) hello6"],
                        Answer = "c",
                        Explanation = "Cannot concatenate str and int objects."
                    },

                    new()
                    {
                        StrQuestion = "What is the output when following code is executed ?<br />>>>print(\"D\", end = ' ')<br />>>>print(\"C\", end = ' ')<br />>>>print(\"B\", end = ' ')<br />>>>print(\"A\", end = ' ')",
                        Options = [ "a) DCBA", "b) A, B, C, D", "c) D C B A", "d) A, B, C, D will be displayed on four lines"],
                        Answer = "c",
                        Explanation = "Execute in the shell."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output when following statement is executed ? (python 3.xx)<br />>>>print(format(\"Welcome\", \"10s\"), end = '#')<br />>>>print(format(111, \"4d\"), end = '#')<br />>>>print(format(924.656, \"3.2f\"))",
                        Options = [ "a) Welcome# 111#924.66", "b) Welcome#111#924.66", "c) Welcome#111#.66", "d) Welcome # 111#924.66"],
                        Answer = "d",
                        Explanation = "Execute in the shell to verify."
                    },

                    new()
                    {
                        StrQuestion = "What will be displayed by print(ord('b') – ord('a')) ?",
                        Options = [ "a) 0", "b) 1", "c) -1", "d) 2"],
                        Answer = "b",
                        Explanation = "The ASCII value of b is one more than a."
                    },

                    new()
                    {
                        StrQuestion = "Say s=\" hello\" what will be the return value of type(s) ?",
                        Options = [ "a) int", "b) bool", "c) str", "d) String"],
                        Answer = "c",
                        Explanation = "str is used to represent strings in python."
                    },

                    new()
                    {
                        StrQuestion = "What is “ Hello” .replace(“ l” , “ e” )",
                        Options = [ "a) Heeeo", "b) Heelo", "c) Heleo", "d) None"],
                        Answer = "a",
                        Explanation = "Execute in shell to verify."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "To retrieve the character at index 3 from string s=” Hello” what command do we execute (multiple answers allowed) ?",
                        Options = [ "a) s.getitem(3)", "b) s.__getitem__(3)", "c) s.getItem(3)"],
                        Answer = "b) s.__getitem__(3)",
                        Explanation = "__getitem(..) can be used to get character at index specified as parameter."
                    },

                     new()
                    {
                        StrQuestion = "To retrieve the character at index 3 from string s=” Hello” what command do we execute (multiple answers allowed) ?",
                        Options = [ "a) s[3]", "b) s.getitem(3)", "c) s.getItem(3)"],
                        Answer = "a) s[3]",
                        Explanation = "__getitem(..) can be used to get character at index specified as parameter."
                    },

                    new()
                    {
                        StrQuestion = "If a class defines the __str__(self) method, for an object obj for the class, you cannot use which command to invoke the __str__ method.(multiple answers allowed)",
                        Options = [ "a) obj.__str__()", "b) str(obj)", "c) print obj", "d) __str__(obj)"],
                        Answer = "d) __str__(obj)",
                        Explanation = "Execute in shell to verify."
                    },

                    new()
                    {
                        StrQuestion = "To check whether string s1 contains s2, use",
                        Options = [ "a) s1.__contains__(s2)", "b) s1 in s2", "c) s1.contains(s2)", "d) s1.in(s2)"],
                        Answer = "a,b",
                        Explanation = "s1 in s2 works in the same way as calling the special function __contains__."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Suppose i is 5 and j is 4, i + j is same as",
                        Options = [ "a) i.__add(j)", "b) i.__add__(j)", "c) i.__Add(j)", "d) i.__ADD(j)"],
                        Answer = "b",
                        Explanation = "Execute in shell to verify."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following code ?<br />class Count:<br />def __init__(self, count = 0):<br />self.__count = count<br />c1 = Count(2)<br />c2 = Count(2)<br />print(id(c1) == id(c2), end = \" \")<br />s1 = \"Good\"<br />s2 = \"Good\"<br />print(id(s1) == id(s2))",
                        Options = [ "a) True False", "b) True True", "c) False True", "d) False False"],
                        Answer = "c",
                        Explanation = "Execute in the shell objects cannot have same id, however in the case of strings it's different."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following code ?<br />class Name:<br />def __init__(self, firstName, mi, lastName):<br />self.firstName = firstName<br />self.mi = mi<br />self.lastName = lastName<br />firstName = \"John\"<br />name = Name(firstName, 'F', \"Smith\")<br />firstName = \"Peter\"<br />name.lastName = \"Pan\"<br />print(name.firstName, name.lastName)",
                        Options = [ "a) Peter Pan.", "b) John Pan.", "c) Peter Smith.", "d) John Smith."],
                        Answer = "b",
                        Explanation = "Execute in the shell to verify."
                    },

                    new()
                    {
                        StrQuestion = "What function do you use to read a string?",
                        Options = [ "a) input(“Enter a string” )", "b) eval(input(“Enter a string” ))", "c) enter(“Enter a string” )", "d) eval(enter(“Enter a string” ))"],
                        Answer = "a",
                        Explanation = "Execute in shell to verify."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Suppose x is 345.3546, what is format(x, “10.3f” ) (_ indicates space)",
                        Options = [ "a) __345.355", "b) ___345.355", "c) ____345.355", "d) _____345.354"],
                        Answer = "b",
                        Explanation = "Execute in the shell to verify."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"abc DEF\".capitalize())",
                        Options = [ "a) abc def", "b) ABC DEF", "c) Abc def", "d) Abc Def"],
                        Answer = "c",
                        Explanation = "The first letter of the string is converted to uppercase and the others are converted to lowercase."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"abc. DEF\".capitalize())",
                        Options = [ "a) abc def", "b) ABC DEF", "c) Abc def", "d) Abc Def"],
                        Answer = "c",
                        Explanation = "The first letter of the string is converted to uppercase and the others are converted to lowercase."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"abcdef\".center())",
                        Options = [ "a) cd", "b) abcdef", "c) error", "d) none of the mentioned"],
                        Answer = "c",
                        Explanation = "The function center() takes at least one parameter."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"abcdef\".center(0))",
                        Options = [ "a) cd", "b) abcdef", "c) error", "d) none of the mentioned"],
                        Answer = "c",
                        Explanation = "The entire string is printed when the argument passed to center() is less than the length of the string."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('*', \"abcdef\".center(7), '*')",
                        Options = [ "a) * abcdef *", "b) * abcdef *", "c) *abcdef *", "d) * abcdef*"],
                        Answer = "b",
                        Explanation = "Padding is done towards the left-hand side first when the final string is of odd length. Extra spaces are present since we haven’t overridden the value of sep."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('*', \"abcdef\".center(7), '*', sep='')",
                        Options = [ "a) * abcdef *", "b) * abcdef *", "c) *abcdef *", "d) * abcdef*"],
                        Answer = "d",
                        Explanation = "Padding is done towards the left-hand side first when the final string is of odd length."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('*', \"abcde\".center(6), '*', sep='')",
                        Options = [ "a) * abcde *", "b) * abcde *", "c) *abcde *", "d) * abcde*"],
                        Answer = "c",
                        Explanation = "Padding is done towards the right-hand side first when the final string is of even length."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"abcdef\".center(7, 1))",
                        Options = [ "a) 1abcdef", "b) abcdef1", "c) abcdef", "d) error"],
                        Answer = "d",
                        Explanation = "TypeError, the fill character must be a character, not an int."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"abcdef\".center(7, '1'))",
                        Options = [ "a) 1abcdef", "b) abcdef1", "c) abcdef", "d) error"],
                        Answer = "a",
                        Explanation = "The character ‘1’ is used for padding instead of a space."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"abcdef\".center(10, '12'))",
                        Options = [ "a) 12abcdef12", "b) abcdef1212", "c) 1212abcdef", "d) error"],
                        Answer = "d",
                        Explanation = "The fill character must be exactly one character long."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"xyyzxyzxzxyy\".count('yy'))",
                        Options = [ "a) 2", "b) 0", "c) error", "d) none of the mentioned"],
                        Answer = "a",
                        Explanation = "Counts the number of times the substring ‘yy’ is present in the given string."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"xyyzxyzxzxyy\".count('yy', 1))",
                        Options = [ "a) 2", "b) 0", "c) 1", "d) none of the mentioned"],
                        Answer = "a",
                        Explanation = "Counts the number of times the substring ‘yy’ is present in the given string, starting from position 1."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"xyyzxyzxzxyy\".count('yy', 2))",
                        Options = [ "a) 2", "b) 0", "c) 1", "d) none of the mentioned"],
                        Answer = "c",
                        Explanation = "Counts the number of times the substring ‘yy’ is present in the given string, starting from position 2."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"xyyzxyzxzxyy\".count('xyy', 0, 100))",
                        Options = [ "a) 2", "b) 0", "c) 1", "d) error"],
                        Answer = "a",
                        Explanation = "An error will not occur if the end value is greater than the length of the string itself."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"xyyzxyzxzxyy\".count('xyy', 2, 11))",
                        Options = [ "a) 2", "b) 0", "c) 1", "d) error"],
                        Answer = "b",
                        Explanation = "Counts the number of times the substring ‘xyy’ is present in the given string, starting from position 2 and ending at position 11."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"xyyzxyzxzxyy\".count('xyy', -10, -1))",
                        Options = [ "a) 2", "b) 0", "c) 1", "d) error"],
                        Answer = "b",
                        Explanation = "Counts the number of times the substring ‘xyy’ is present in the given string, starting from position -10 and ending at position -1."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('abc'.encode())",
                        Options = [ "a) abc", "b) ‘abc’", "c) b’ abc’", "d) h’ abc’"],
                        Answer = "c",
                        Explanation = "A bytes object is returned by encode."
                    },

                    new()
                    {
                        StrQuestion = "What is the default value of encoding in encode()?",
                        Options = [ "a) ascii", "b) qwerty", "c) utf-8", "d) utf-16"],
                        Answer = "c",
                        Explanation = "The default value of encoding is utf-8."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"xyyzxyzxzxyy\".endswith(\"xyy\"))",
                        Options = [ "a) 1", "b) True", "c) 3", "d) 2"],
                        Answer = "b",
                        Explanation = "The function returns True if the given string ends with the specified substring."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print(\"xyyzxyzxzxyy\".endswith(\"xyy\", 0, 2))",
                        Options = [ "a) 0", "b) 1", "c) True", "d) False"],
                        Answer = "d",
                        Explanation = "The function returns False if the given string does not end with the specified substring."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('abcdefcdghcd'.split('cd', 2))",
                        Options = [ "a) ['ab', 'ef', 'ghcd']", "b) ['ab', 'efcdghcd']", "c) ['abcdef', 'ghcd']", "d) none of the mentioned"],
                        Answer = "a",
                        Explanation = "The string is split into a maximum of maxsplit+1 substrings."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('ab\\ncd\\nef'.splitlines())",
                        Options = [ "a) ['ab', 'cd', 'ef']", "b) ['ab\\n', 'cd\\n', 'ef\\n']", "c) ['ab\\n', 'cd\\n', 'ef']", "d) ['ab', 'cd', 'ef\\n']"],
                        Answer = "a",
                        Explanation = "It is similar to calling split('\\n')."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('Ab!2'.swapcase())",
                        Options = [ "a) AB!@", "b) ab12", "c) aB!2", "d) aB1@"],
                        Answer = "c",
                        Explanation = "Lowercase letters are converted to uppercase and vice-versa."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('ab cd ef'.title())",
                        Options = [ "a) Ab cd ef", "b) Ab cd eF", "c) Ab Cd Ef", "d) none of the mentioned"],
                        Answer = "c",
                        Explanation = "The first letter of every word is capitalized."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('ab cd-ef'.title())",
                        Options = [ "a) Ab cd-ef", "b) Ab Cd-ef", "c) Ab Cd-Ef", "d) none of the mentioned"],
                        Answer = "c",
                        Explanation = "The first letter of every word is capitalized. Special symbols terminate a word."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('abcd'.translate('a'.maketrans('abc', 'bcd')))",
                        Options = [ "a) bcde", "b) abcd", "c) error", "d) none of the mentioned"],
                        Answer = "d",
                        Explanation = "The output is bcdd since no translation is provided for d."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('abcd'.translate({97: 98, 98: 99, 99: 100}))",
                        Options = [ "a) bcde", "b) abcd", "c) error", "d) none of the mentioned"],
                        Answer = "d",
                        Explanation = "The output is bcdd since no translation is provided for d."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('abcd'.translate({'a': '1', 'b': '2', 'c': '3', 'd': '4'}))",
                        Options = [ "a) abcd", "b) 1234", "c) error", "d) none of the mentioned"],
                        Answer = "a",
                        Explanation = "The function translate expects a dictionary of integers. Use maketrans() instead of doing the above."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('ab'.zfill(5))",
                        Options = [ "a) 000ab", "b) 00ab0", "c) 0ab00", "d) ab000"],
                        Answer = "a",
                        Explanation = "The string is padded with zeroes on the left-hand side. It is useful for formatting numbers."
                    },

                    new()
                    {
                        StrQuestion = "What is the output of the following?<br />print('+99'.zfill(5))",
                        Options = [ "a) 00+99", "b) 00099", "c) +0099", "d) +++99"],
                        Answer ="c) +0099",
                        Explanation = "Zeroes are filled in between the first sign and the rest of the string."
                    },


                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What is the output when we execute list('hello')?",
                        Options = [ "['h', 'e', 'l', 'l', 'o']", "['hello']", "['llo']", "['olleh']"],
                        Answer = "['h', 'e', 'l', 'l', 'o']",
                        Explanation = "The list() function converts the string into a list of characters."
                    },

                    new()
                    {
                        StrQuestion = "Suppose listExample = ['h', 'e', 'l', 'l', 'o'], what is len(listExample)?",
                        Options = [ "5", "4", "None", "Error"],
                        Answer = "5",
                        Explanation = "The length of the list is 5 because it contains 5 elements."
                    },

                    new()
                    {
                        StrQuestion = "Suppose list1 = [2445, 133, 12454, 123], what is max(list1)?",
                        Options = [ "2445", "133", "12454", "123"],
                        Answer = "12454",
                        Explanation = "max() returns the maximum element in the list, which is 12454."
                    },

                    new()
                    {
                        StrQuestion = "Suppose list1 = [3, 5, 25, 1, 3], what is min(list1)?",
                        Options = [ "3", "5", "25", "1"],
                        Answer = "1",
                        Explanation = "min() returns the minimum element in the list, which is 1."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Suppose list1 = [1, 5, 9], what is sum(list1)?",
                        Options = [ "1", "9", "15", "Error"],
                        Answer = "15",
                        Explanation = "sum() returns the sum of all elements in the list, which is 1 + 5 + 9 = 15."
                    },

                    new()
                    {
                        StrQuestion = "To shuffle the list (list1), what function do we use?",
                        Options = [ "list1.shuffle()", "shuffle(list1)", "random.shuffle(list1)", "random.shuffleList(list1)"],
                        Answer = "random.shuffle(list1)",
                        Explanation = "The correct method is random.shuffle(list1)."
                    },

                    new()
                    {
                        StrQuestion = "Suppose list1 = [2, 33, 222, 14, 25], what is list1[-1]?",
                        Options = [ "Error", "None", "25", "2"],
                        Answer = "25",
                        Explanation = "-1 refers to the last element in the list, which is 25."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Suppose list1 = [2, 33, 222, 14, 25], what is list1[:-1]?",
                        Options = [ "[2, 33, 222, 14]", "Error", "25", "[25, 14, 222, 33, 2]"],
                        Answer = "[2, 33, 222, 14]",
                        Explanation = "[:-1] slices the list from the start up to (but not including) the last element."
                    },

                    new()
                    {
                        StrQuestion = "What is the output when the following code is executed? <br />>>> names = ['Amir', 'Bear', 'Charlton', 'Daman'] <br />>>> print(names[-1][-1])",
                        Options = [ "A", "Daman", "Error", "n"],
                        Answer = "n",
                        Explanation = "names[-1] refers to 'Daman', and [-1] on 'Daman' refers to the last character 'n'."
                    },

                    new() {
                        StrQuestion = "What is the output when the following code is executed? <br />>>> names1 = ['Amir', 'Bear', 'Charlton', 'Daman'] <br />names2 = names1 <br />names3 = names1[:] <br />names2[0] = 'Alice' <br />names3[1] = 'Bob' <br />sum = 0 <br />for ls in (names1, names2, names3): <br />    if ls[0] == 'Alice': <br />        sum += 1 <br />    if ls[1] == 'Bob': <br />        sum += 10 <br />print(sum)",
                        Options = [ "11", "12", "21", "22"],
                        Answer = "12",
                        Explanation = "When assigning names1 to names2, we create a second reference to the same list. Changes to names2 affect names1. When assigning the slice of all elements in names1 to names3, we are creating a full copy of names1 which can be modified independently."
                    },

                    new() {
                        StrQuestion = "Suppose list1 = [1, 3, 2], what is list1 * 2?",
                        Options = [ "[2, 6, 4]", "[1, 3, 2, 1, 3]", "[1, 3, 2, 1, 3, 2]", "[1, 3, 2, 3, 2, 1]"],
                        Answer = "[1, 3, 2, 1, 3, 2]",
                        Explanation = "The * 2 operation repeats the list twice."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Suppose list1 = [0.5 * x for x in range(0, 4)], what is list1?",
                        Options = [ "[0, 1, 2, 3]", "[0, 1, 2, 3, 4]", "[0.0, 0.5, 1.0, 1.5]", "[0.0, 0.5, 1.0, 1.5, 2.0]"],
                        Answer = "[0.0, 0.5, 1.0, 1.5]",
                        Explanation = "The list comprehension multiplies each element in the range by 0.5."
                    },

                    new()
                    {
                        StrQuestion = "What is the output when the following code is executed? <br />>>> list1 = [11, 2, 23] <br />>>> list2 = [11, 2, 2] <br />>>> list1 < list2",
                        Options = [ "True", "False", "Error", "None"],
                        Answer = "False",
                        Explanation = "Lists are compared element by element, and in this case, 23 is greater than 2, so list1 < list2 is False."
                    },

                    new()
                    {
                        StrQuestion = "To add a new element to a list, we use which command?",
                        Options = [ "list1.add(5)", "list1.append(5)", "list1.addLast(5)", "list1.addEnd(5)"],
                        Answer = "list1.append(5)",
                        Explanation = "We use the function append() to add an element to the list."
                    },

                    new()
                    {
                        StrQuestion = "To insert 5 into the third position in list1, we use which command?",
                        Options = [ "list1.insert(3, 5)", "list1.insert(2, 5)", "list1.add(3, 5)", "list1.append(3, 5)"],
                        Answer = "list1.insert(3, 5)",
                        Explanation = "The insert() method inserts an element at the specified index."
                    },

                ],


            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "To remove the string 'hello' from list1, we use which command?",
                        Options = [ "list1.remove('hello')", "list1.remove(hello)", "list1.removeAll('hello')", "list1.removeOne('hello')"],
                        Answer = "list1.remove('hello')",
                        Explanation = "The remove() method removes the first occurrence of the specified value."
                    },

                    new()
                    {
                        StrQuestion = "Suppose list1 = [3, 4, 5, 20, 5], what is list1.index(5)?",
                        Options = [ "0", "1", "4", "2"],
                        Answer = "2",
                        Explanation = "index() returns the index of the first occurrence of the specified value, which is 2 for the first 5."
                    },

                    new()
                    {
                        StrQuestion = "Suppose list1 = [3, 4, 5, 20, 5, 25, 1, 3], what is list1.count(5)?",
                        Options = [ "0", "4", "1", "2"],
                        Answer = "2",
                        Explanation = "count() returns the number of occurrences of the specified value, which is 2 for the value 5."
                    },

                    new()
                    {
                        StrQuestion = "What will be the output?<br /><br />" +
                                    "def f(i, values = []):<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;values.append(i)<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;return values<br />" +
                                    "f(1)<br />" +
                                    "f(2)<br />" +
                                    "v = f(3)<br />" +
                                    "print(v)",
                        Options = [
                            "[1] [2] [3]",
                            "[1] [1, 2]",
                            "[1, 2, 3]",
                            "1 2 3"
                        ],
                        Answer = "[1, 2, 3]",
                        Explanation = "The default argument `values` retains its state between function calls, so after `f(1)`, `f(2)`, and `f(3)`, `values` ends up containing `[1, 2, 3]`."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What will be the output?<br /><br />" +
                                    "list1 = [1, 2, 3, 4]<br />" +
                                    "list2 = [5, 6, 7, 8]<br />" +
                                    "print(len(list1 + list2))",
                        Options = [
                            "2",
                            "4",
                            "5",
                            "8"
                        ],
                        Answer = "8",
                        Explanation = "The `+` operator concatenates the two lists, so the result is `[1, 2, 3, 4, 5, 6, 7, 8]`, which has a length of 8."
                    },

                    new()
                    {
                        StrQuestion = "What will be the output?<br /><br />" +
                                    "def addItem(listParam):<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;listParam += [1]<br />" +
                                    "mylist = [1, 2, 3, 4]<br />" +
                                    "addItem(mylist)<br />" +
                                    "print(len(mylist))",
                        Options = [
                            "1",
                            "4",
                            "5",
                            "8"
                        ],
                        Answer = "5",
                        Explanation = "The `+=` operator modifies the list in place, so the list `mylist` becomes `[1, 2, 3, 4, 1]`, increasing its length to 5."
                    },

                    new()
                    {
                        StrQuestion = "What will be the output?<br /><br />" +
                                    "def increment_items(L, increment):<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;i = 0<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;while i < len(L):<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;L[i] = L[i] + increment<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;i = i + 1<br />" +
                                    "values = [1, 2, 3]<br />" +
                                    "print(increment_items(values, 2))<br />" +
                                    "print(values)",
                        Options = [
                            "None [3, 4, 5]",
                            "None [1, 2, 3]",
                            "[3, 4, 5] [1, 2, 3]",
                            "[3, 4, 5] None"
                        ],
                        Answer = "None [3, 4, 5]",
                        Explanation = "The function modifies the list `values` in place. It returns `None` because there is no explicit return value in the function. The list `values` is updated to `[3, 4, 5]`."
                    },

                    new()
                    {
                        StrQuestion = "What will be the output?<br /><br />" +
                                    "def example(L):<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;''' (list) -> list '''<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;i = 0<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;result = []<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;while i < len(L):<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;result.append(L[i])<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;i = i + 3<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;return result",
                        Options = [
                            "Return a list containing every third item from L starting at index 0.",
                            "Return an empty list",
                            "Return a list containing every third index from L starting at index 0.",
                            "Return a list containing the items from L starting from index 0, omitting every third item."
                        ],
                        Answer = "Return a list containing every third item from L starting at index 0.",
                        Explanation = "The function appends every third element starting from index 0."
                    },

                ],


            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What will be the output?<br /><br />" +
                                    "veggies = ['carrot', 'broccoli', 'potato', 'asparagus']<br />" +
                                    "veggies.insert(veggies.index('broccoli'), 'celery')<br />" +
                                    "print(veggies)",
                        Options = [
                            "['carrot', 'celery', 'broccoli', 'potato', 'asparagus']",
                            "['carrot', 'celery', 'potato', 'asparagus']",
                            "['carrot', 'broccoli', 'celery', 'potato', 'asparagus']",
                            "['celery', 'carrot', 'broccoli', 'potato', 'asparagus']"
                        ],
                        Answer = "['carrot', 'celery', 'broccoli', 'potato', 'asparagus']",
                        Explanation = "The `insert()` method inserts 'celery' before 'broccoli' at the index where 'broccoli' is found."
                    },

                    new()
                    {
                        StrQuestion = "What will be the output?<br /><br />" +
                                    "def f(i, values = []):<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;values.append(i)<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;return values<br />" +
                                    "f(1)<br />" +
                                    "f(2)<br />" +
                                    "v = f(3)<br />" +
                                    "print(v)",
                        Options = [
                            "[1] [2] [3]",
                            "[1] [1, 2]",
                            "[1, 2, 3]",
                            "1 2 3"
                        ],
                        Answer = "[1, 2, 3]",
                        Explanation = "The default argument `values` retains its state between function calls, so after `f(1)`, `f(2)`, and `f(3)`, `values` ends up containing `[1, 2, 3]`."
                    },

                    new()
                    {
                        StrQuestion = "What will be the output?<br /><br />" +
                                    "names1 = ['Amir', 'Bala', 'Chales']<br />" +
                                    "if 'amir' in names1:<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;print(1)<br />" +
                                    "else:<br />" +
                                    "&nbsp;&nbsp;&nbsp;&nbsp;print(2)",
                        Options = [
                            "None",
                            "1",
                            "2",
                            "Error"
                        ],
                        Answer = "2",
                        Explanation = "'amir' is lowercase, but 'Amir' in the list is capitalized, so 'amir' is not found, and '2' is printed."
                    },

                    new()
                    {
                        StrQuestion = "What will be the output?<br /><br />" +
                                    "names1 = ['Amir', 'Bala', 'Charlie']<br />" +
                                    "names2 = [name.lower() for name in names1]<br />" +
                                    "print(names2[2][0])",
                        Options = [
                            "None",
                            "a",
                            "b",
                            "c"
                        ],
                        Answer = "a",
                        Explanation = "The names in `names2` are converted to lowercase, so 'charlie' is the third name. The first character of 'charlie' is 'c'."
                    },

                ],


            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "What will be the output?<br /><br />" +
                                    "numbers = [1, 2, 3, 4]<br />" +
                                    "numbers.append([5, 6, 7, 8])<br />" +
                                    "print(len(numbers))",
                        Options = [
                            "4",
                            "5",
                            "8",
                            "12"
                        ],
                        Answer = "5",
                        Explanation = "The `append()` method adds a list as a single element, so the list `numbers` contains 5 elements, including the list `[5, 6, 7, 8]`."
                    },

                    new()
                    {
                        StrQuestion = "To which of the following can the 'in' operator be used to check if an item is in it?",
                        Options = [
                            "Lists",
                            "Dictionary",
                            "Set",
                            "All of The Above"
                        ],
                        Answer = "All of The Above",
                        Explanation = "'in' can be used to check membership in lists, dictionaries, and sets."
                    },

                    new()
                    {
                        StrQuestion = "What will be the output?<br /><br />" +
                                    "list1 = [1, 2, 3, 4]<br />" +
                                    "list2 = [5, 6, 7, 8]<br />" +
                                    "print(len(list1 + list2))",
                        Options = [
                            "2",
                            "4",
                            "5",
                            "8"
                        ],
                        Answer = "8",
                        Explanation = "The `+` operator concatenates the two lists, so the result is `[1, 2, 3, 4, 5, 6, 7, 8]`, which has a length of 8."
                    },

                ],


            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new()
                    {
                        StrQuestion = "Suppose t = (1, 2, 4, 3), which of the following is incorrect?",
                        Options = [
                            "print(t[3])",
                            "t[3] = 45",
                            "print(max(t))",
                            "print(len(t))"
                        ],
                        Answer = "t[3] = 45",
                        Explanation = "Values cannot be modified in the case of a tuple."
                    },

                    new()
                    {
                        StrQuestion = "What will be the output?<br />>>>t=(1,2,4,3)<br />>>>t[1:3]",
                        Options = [
                            "(1, 2)",
                            "(1, 2, 4)",
                            "(2, 4)",
                            "(2, 4, 3)"
                        ],
                        Answer = "(2, 4)",
                        Explanation = "Slicing works the same as with strings in tuples."
                    },

                    new()
                    {
                        StrQuestion = "What will be the output?<br />>>>t=(1,2,4,3)<br />>>>t[1:-1]",
                        Options = [
                            "(1, 2)",
                            "(1, 2, 4)",
                            "(2, 4)",
                            "(2, 4, 3)"
                        ],
                        Answer = "(2, 4)",
                        Explanation = "Slicing works the same as with strings in tuples."
                    },

                    new()
                    {
                        StrQuestion = "What will be the output?<br />>>>t = (1, 2, 4, 3, 8, 9)<br />>>>[t[i] for i in range(0, len(t), 2)]",
                        Options = [
                            "[2, 3, 9]",
                            "[1, 2, 4, 3, 8, 9]",
                            "[1, 4, 8]",
                            "(1, 4, 8)"
                        ],
                        Answer = "[1, 4, 8]",
                        Explanation = "The list comprehension selects elements at even indices."
                    },

                ],


            },

            new("CSC201")
            {
                QuestionsList =
                [

                    new()
                    {
                        StrQuestion = "What will be the output?<br />d = {\"john\":40, \"peter\":45}<br />d[\"john\"]",
                        Options = [
                            "40",
                            "45",
                            "\"john\"",
                            "\"peter\""
                        ],
                        Answer = "40",
                        Explanation = "The value associated with the key 'john' in the dictionary is 40."
                    },

                    new()
                    {
                        StrQuestion = "What will be the output?<br />>>>t = (1, 2)<br />>>>2 * t",
                        Options = [
                            "(1, 2, 1, 2)",
                            "[1, 2, 1, 2]",
                            "(1, 1, 2, 2)",
                            "[1, 1, 2, 2]"
                        ],
                        Answer = "(1, 2, 1, 2)",
                        Explanation = "The '*' operator duplicates the tuple."
                    },

                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new() {
                             StrQuestion = "What will be the output?<br />>>>my_tuple = (1, 2, 3, 4)<br />>>>my_tuple.append( (5, 6, 7) )<br />>>>print(len(my_tuple))",
                             Options = [
                            "1",
                            "2",
                            "5",
                            "Error"
                        ],
                        Answer = "Error",
                        Explanation = "Tuples are immutable and don’t have an append method. An exception is thrown."
                    },

                    new() {
                        StrQuestion = "What will be the output?<br />numberGames = {}<br />numberGames[(1,2,4)] = 8<br />numberGames[(4,2,1)] = 10<br />numberGames[(1,2)] = 12<br />sum = 0<br />for k in numberGames:<br />sum += numberGames[k]<br />print(len(numberGames) + sum)",
                        Options = [
                            "30",
                            "24",
                            "33",
                            "12"
                        ],
                        Answer = "33",
                        Explanation = "Tuples can be used as dictionary keys, and the order of elements matters when comparing keys."
                    },



                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                     new()
                     {
                        StrQuestion = "What is the output of the following?",
                        Options = [ "a) m, y, , n, a, m, e, , i, s, , x,", "b) m, y, , n, a, m, e, , i, s, , x", "c) my, name, is, x,", "d) error"],
                        Answer = "a) m, y, , n, a, m, e, , i, s, , x,",
                        Explanation = "Variable i takes the value of one character at a time."
                     },

                    new()
                    {
                        StrQuestion = "What is the output when following statement is executed ?<br />>>>print 'new' 'line'",
                        Options = [ "a) Error", "b) Output equivalent to print ‘new\\nline’", "c) newline", "d) new line"],
                        Answer = "c) newline",
                        Explanation = "String literals separated by white space are allowed. They are concatenated."
                    },
                ],
            },

            new("CSC201")
            {
                QuestionsList =
                [
                    new ()
                    {
                        StrQuestion = "Which of the following is a Python tuple?",
                        Options = [
                            "[1, 2, 3]",
                            "(1, 2, 3)",
                            "{1, 2, 3}",
                            "{}"
                        ],
                        Answer = "(1, 2, 3)",
                        Explanation = "Tuples are characterized by their round brackets."
                    },

                    new()
                    {
                        StrQuestion = "Which of the following will run without errors?",
                        Options = [ "round(6352.898, 2)", "round()", "round(7463.123,2,1)"],
                        Answer =  "round(6352.898, 2)",
                        Explanation = "The round() function can take one or two arguments. The first argument is a number to round, and the second is an optional precision value."
                    },
                ],


            },

#endregion


            
            //CSC202 202 202 202 202 202 202 202 202 202 202 202 202
            //CSC202 202 202 202 202 202 202 202 202 202 202 202 202

        ];
        public static List<QuestionPreset> GetQuestion(string CourseCode) => Questions_!.Where(x => (x.CourseCode == CourseCode && x.QuestionsList != null)).ToList();
    }
}
