using System.Numerics;

namespace AdventOfCode2020;

public class Day10
{
    public static void Part1(string input)
    {
        Console.WriteLine();
        Console.WriteLine("Day10 Part1");

        var adaptors = input.Split(Environment.NewLine).Select(int.Parse).ToArray();
        var orderedAdaptors = new[] {0}.Union(adaptors.OrderBy(a => a)).Union(new[] {adaptors.Max() + 3}).ToArray();
        var onesCount = 0;
        var threesCount = 0;
        for (var i = 1; i < orderedAdaptors.Length; i++)
        {
            if (orderedAdaptors[i] - orderedAdaptors[i - 1] == 1)
            {
                onesCount++;
            }
            if (orderedAdaptors[i] - orderedAdaptors[i - 1] == 3)
            {
                threesCount++;
            }
        }
        Console.WriteLine(onesCount * threesCount);
    }

    public static void Part2(string input)
    {
        Console.WriteLine();
        Console.WriteLine("Day10 Part2");

        var adaptors = input.Split(Environment.NewLine).Select(int.Parse).ToArray();
        var orderedAdaptors = new[] {0}.Union(adaptors.OrderBy(a => a)).Union(new[] {adaptors.Max() + 3}).ToArray();

        long possibles = 1;
        var multiplier = 1;
        for (var i = 0; i < orderedAdaptors.Length - 3; i++)
        {
            for (var j = i + 2; j < orderedAdaptors.Length - 1; j++)
            {
                if (orderedAdaptors[j] - orderedAdaptors[i] <= 3)
                {
                    multiplier ++;
                }
                else
                {
                    break;
                }
            }

            if (orderedAdaptors[i + 1] - orderedAdaptors[i] > 3)
            {
                possibles *= multiplier;
                multiplier = 1;
            }
        }
        Console.WriteLine(possibles);
    }

    public static string TestInputShort = @"3
4
5
6
7
10";

    public static string TestInput = @"28
33
18
42
31
14
46
20
48
47
24
23
49
45
19
38
39
11
1
32
25
35
8
17
7
9
4
2
34
10
3";

    public static string Input = @"99
151
61
134
112
70
75
41
119
137
158
50
167
60
116
117
62
82
31
3
72
88
165
34
8
14
27
108
166
71
51
42
135
122
140
109
1
101
2
77
85
76
143
100
127
7
107
13
148
118
56
159
133
21
154
152
130
78
54
104
160
153
95
49
19
69
142
63
11
12
29
98
84
28
17
146
161
115
4
94
24
126
136
91
57
30
155
79
66
141
48
125
162
37
40
147
18
20
45
55
83";
}