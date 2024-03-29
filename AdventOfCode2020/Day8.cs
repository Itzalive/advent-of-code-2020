﻿namespace AdventOfCode2020;

public class Day8
{
    public static void Part1(string input)
    {
        Console.WriteLine();
        Console.WriteLine("Day8 Part1");

        var instructions = input.Split(Environment.NewLine).Select(l => l.Split(" "))
            .Select(l => new Instruction{Operation = l[0], Value = int.Parse(l[1]), IsRun = false}).ToArray();

        var possibleInstructions = new List<Instruction[]> {instructions};
        for(var i = 0; i< instructions.Length; i++)
        {
            if (instructions[i].Operation == "jmp")
            {
                var newInstructions = new Instruction[instructions.Length];
                instructions.CopyTo(newInstructions, 0);
                newInstructions[i] = new Instruction {Operation = "nop", Value = instructions[i].Value};
                possibleInstructions.Add(newInstructions);
            }
            if (instructions[i].Operation == "nop") {
                var newInstructions = new Instruction[instructions.Length];
                instructions.CopyTo(newInstructions, 0);
                newInstructions[i] = new Instruction {Operation = "jmp", Value = instructions[i].Value};
                possibleInstructions.Add(newInstructions);
            }
        }

        foreach (var instructionSet in possibleInstructions)
        {
            foreach (var instruction in instructionSet)
            {
                instruction.IsRun = false;
            }
            var currentInstruction = 0;
            var accumulator = 0;
            while (currentInstruction < instructionSet.Length && !instructionSet[currentInstruction].IsRun)
            {
                var instruction = instructionSet[currentInstruction];
                instruction.IsRun = true;
                switch (instruction.Operation)
                {
                    case "acc":
                        accumulator += instruction.Value;
                        currentInstruction++;
                        break;
                    case "jmp":
                        currentInstruction += instruction.Value;
                        break;
                    case "nop":
                        currentInstruction++;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            if (currentInstruction == instructionSet.Length)
                Console.WriteLine(accumulator);
        }
    }

    public static void Part2(string input)
    {
        Console.WriteLine();
        Console.WriteLine("Day8 Part2");
    }

    public static string TestInput = @"nop +0
acc +1
jmp +4
acc +3
jmp -3
acc -99
acc +1
jmp -4
acc +6";

    public static string Input = @"acc +40
jmp +187
acc +47
acc +20
acc -12
jmp +225
nop +488
acc +13
nop +462
jmp +374
acc +15
acc +42
jmp +116
acc +23
nop +216
acc -15
jmp +398
jmp +103
acc +17
acc +7
jmp +571
jmp +1
jmp +217
acc +7
jmp +1
acc +35
jmp +257
acc +24
nop +20
jmp +309
acc +2
acc -15
acc -13
nop +457
jmp +19
acc +46
acc +45
acc +35
jmp +295
acc -15
acc +49
acc +22
jmp +400
jmp +202
nop -38
jmp +381
acc +0
jmp +137
acc +27
jmp +196
acc +46
acc -15
jmp +348
jmp +457
acc +50
acc +8
jmp +452
acc -14
nop +321
acc +39
jmp +273
acc -9
jmp +413
acc +32
jmp +64
acc +18
jmp +152
acc -4
acc +9
acc +10
acc -1
jmp +433
acc +40
jmp -55
acc +28
nop +279
jmp +145
acc +24
nop +416
acc +45
jmp +45
acc +0
acc +49
acc -14
jmp +44
acc +17
acc +18
nop +224
acc +3
jmp +261
jmp -84
acc -11
acc +29
acc +42
jmp -13
acc -5
jmp +210
acc +26
acc -19
acc -19
jmp -82
acc +29
acc +31
acc -4
jmp +53
acc +46
jmp +139
acc +45
acc +30
jmp +1
jmp +418
jmp +248
acc +24
acc +15
acc +34
acc +17
jmp +52
acc +23
acc +18
jmp +65
jmp +1
acc +37
acc +25
jmp +385
jmp +281
nop +345
jmp -25
jmp +149
acc +21
acc +28
acc +15
jmp -74
jmp +179
jmp +287
acc +14
acc -3
acc -7
jmp -9
acc +17
acc -8
jmp +344
jmp +1
acc +36
acc -16
acc -17
jmp -82
jmp +1
acc +41
acc -8
acc +27
jmp +381
acc -10
nop -71
acc +23
nop +377
jmp -125
jmp +319
nop +119
nop +309
nop +195
jmp +307
acc +8
acc +31
jmp +1
acc -15
jmp +398
jmp +265
jmp -55
nop +143
jmp -36
acc +38
nop -38
jmp +298
acc -17
acc +39
acc -13
jmp -38
acc +23
jmp +133
acc +23
jmp -90
acc +14
jmp +1
jmp +100
nop +230
jmp +346
acc +36
jmp +14
jmp +126
jmp -32
jmp -142
acc +25
jmp +146
nop +118
acc -3
jmp +1
acc -8
jmp +101
nop +277
acc +27
jmp +328
acc -11
acc +17
nop +135
jmp +196
acc -9
jmp +39
nop +110
acc +14
nop +3
jmp +17
jmp +220
acc +17
jmp +5
acc +18
acc +39
acc -12
jmp -204
jmp +317
acc +37
jmp +222
nop +146
nop +248
jmp +182
acc +48
acc -13
jmp +174
jmp +342
nop -189
jmp +324
acc +35
acc +25
acc +21
jmp -152
nop -92
acc -3
acc -15
acc +30
jmp -157
acc -17
acc +37
acc +7
acc +5
jmp -225
jmp -177
acc +21
jmp +244
acc +42
acc -4
jmp -116
nop +225
nop -63
acc +20
jmp +195
acc +20
acc +21
jmp +228
acc +16
acc -8
acc +12
nop +188
jmp +9
acc +6
acc -13
acc +36
jmp -86
jmp -253
nop -60
acc +25
jmp -174
acc +10
nop -114
jmp -65
jmp +1
acc +24
jmp -150
acc +27
jmp -47
acc +50
nop -58
acc -17
acc -16
jmp -170
jmp -104
jmp -177
acc +46
jmp +106
jmp -206
acc +2
acc +10
acc +17
nop -107
jmp -126
jmp +1
acc +50
acc -14
acc +29
jmp -234
nop +144
acc +43
acc +34
jmp +221
jmp +1
nop +97
acc +39
jmp -60
acc +44
jmp -240
acc +11
acc +36
jmp -71
acc -5
jmp +149
jmp +54
acc +38
jmp +44
jmp -165
acc +14
jmp -134
acc +3
acc +22
nop +46
acc -12
jmp -57
acc +49
acc +24
acc +16
jmp +27
acc +6
nop -5
acc +45
acc +34
jmp -175
jmp -76
acc +3
acc +15
acc -19
jmp +1
nop -226
acc -2
jmp -55
jmp -284
acc +2
jmp +1
jmp +15
acc +11
acc +12
acc -1
acc +2
jmp +179
acc +19
acc +17
jmp -329
jmp -272
jmp -104
acc +41
nop +189
acc +47
jmp -88
acc +4
acc +16
acc +43
acc +25
jmp +71
acc -2
acc +45
jmp -173
jmp +1
acc +44
acc +33
jmp -53
acc +45
acc +9
acc +0
acc +12
jmp +178
jmp -100
acc +14
jmp -67
acc +42
jmp +201
acc +30
jmp -319
nop -4
nop -211
acc -3
nop -165
jmp -175
acc +12
acc -10
acc -14
jmp -53
acc -13
nop -143
jmp +159
acc -5
nop +18
nop -5
acc +13
jmp -248
jmp +114
acc +10
nop -396
nop -246
jmp +16
acc -3
acc +33
nop +174
acc +48
jmp -289
nop +98
acc +18
acc -17
jmp -137
jmp +1
acc +34
acc +36
jmp -216
acc +11
jmp -102
acc +10
jmp +10
acc +26
acc +35
acc -9
jmp -83
acc +15
nop -397
jmp -140
nop +111
jmp +139
jmp -165
acc +16
jmp -343
acc +8
acc +35
acc -17
acc -8
jmp +29
acc +50
nop -256
jmp -268
jmp +132
acc +13
acc +38
acc -6
acc -7
jmp -327
acc -8
jmp -256
nop -139
acc +30
jmp -60
acc -1
acc +11
jmp -216
acc -12
nop -390
acc +17
acc +39
jmp +101
acc +28
jmp +1
acc -7
acc -18
jmp -277
jmp -90
acc -10
jmp -326
jmp -368
nop -396
jmp -320
acc +42
acc +3
jmp -430
acc +47
acc +11
acc +19
acc +41
jmp -354
acc +30
acc +7
nop -106
jmp -420
acc +22
acc -15
jmp -296
acc -7
acc +48
jmp -19
jmp -148
acc +10
jmp +1
jmp +17
nop -273
acc +42
acc -4
nop -130
jmp +47
nop -436
acc -7
jmp +1
acc +42
jmp -330
acc +35
jmp +56
acc -19
jmp -440
jmp -335
jmp -279
nop -390
jmp +74
acc -5
jmp -456
acc +38
acc +3
jmp +47
acc +50
acc +26
acc +46
acc -7
jmp -491
acc -4
acc -7
acc +14
nop -105
jmp -487
jmp -326
nop -360
jmp -378
jmp -285
acc +46
jmp -190
acc +10
jmp -346
acc +49
jmp -492
acc -9
acc -17
jmp -147
acc +20
jmp -217
nop -183
acc +35
jmp -268
nop -51
jmp +1
jmp -440
acc +22
acc +24
jmp +1
acc +26
jmp -451
acc -14
acc +48
acc +3
jmp -363
acc +21
acc +24
acc +36
jmp -418
jmp -108
jmp -323
jmp +20
acc +1
acc +21
nop -212
acc -3
jmp -338
acc +36
acc -19
jmp -192
acc +49
jmp -380
acc -12
acc +14
acc +38
acc +4
jmp -228
acc +2
jmp -197
jmp -41
jmp -265
jmp -113
jmp -459
jmp +1
acc +38
jmp -79
acc +16
nop -456
jmp -129
acc +12
acc +29
nop -575
acc -7
jmp +1";
}

public class Instruction
{
    public string Operation { get; set; }
    public int Value { get; set; }
    public bool IsRun { get; set; }
}