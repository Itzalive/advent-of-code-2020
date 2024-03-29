﻿using System.Text.RegularExpressions;

namespace AdventOfCode2020;

public class Day7
{
    public static void Part1(string input)
    {
        Console.WriteLine();
        Console.WriteLine("Day7 Part1");

        var bags = input.Split(Environment.NewLine).Select(b => new Bag(b)).ToDictionary(b => b.Colour);
        Console.WriteLine(bags.Values.Count(b => b.Contains("shiny gold", bags)));
    }

    public static void Part2(string input)
    {
        Console.WriteLine();
        Console.WriteLine("Day7 Part2");
        var bags = input.Split(Environment.NewLine).Select(b => new Bag(b)).ToDictionary(b => b.Colour);
        Console.WriteLine(bags["shiny gold"].HowManyBags(bags) - 1);
    }

    public class Bag
    {
        public string Colour { get; set; }

        public Dictionary<string, int> Contents { get; set; }

        public Bag(string line)
        {
            var details = line.Split(" bags contain ");
            Colour = details[0];
            Contents = Regex.Matches(details[1], "([0-9]+) ([a-z ]+) bag")
                .ToDictionary(m => m.Groups[2].Value, m => int.Parse(m.Groups[1].Value));
        }

        public bool Contains(string colour, Dictionary<string, Bag> bags)
        {
            if (Contents.ContainsKey(colour)) return true;
            return Contents.Keys.Any(c => bags[c].Contains(colour, bags));
        }

        public int HowManyBags(Dictionary<string, Bag> bags)
        {
            return Contents.Sum(c => c.Value * bags[c.Key].HowManyBags(bags)) + 1;
        }
    }

    public static string TestInput = @"shiny gold bags contain 2 dark red bags.
dark red bags contain 2 dark orange bags.
dark orange bags contain 2 dark yellow bags.
dark yellow bags contain 2 dark green bags.
dark green bags contain 2 dark blue bags.
dark blue bags contain 2 dark violet bags.
dark violet bags contain no other bags.";

    public static string Input = @"vibrant lavender bags contain 1 shiny coral bag, 4 dotted purple bags.
dotted blue bags contain 5 muted violet bags.
faded magenta bags contain 5 dull gold bags, 5 drab blue bags, 2 wavy maroon bags.
wavy black bags contain 2 posh white bags, 1 plaid lavender bag, 4 drab green bags.
wavy olive bags contain 5 mirrored tan bags, 5 vibrant lime bags, 3 dull lime bags, 5 dim lime bags.
light magenta bags contain 3 bright maroon bags, 5 faded yellow bags, 2 dim indigo bags.
shiny indigo bags contain no other bags.
faded bronze bags contain 2 pale orange bags, 4 vibrant tomato bags, 3 clear tomato bags, 1 vibrant beige bag.
plaid crimson bags contain 2 drab purple bags, 5 drab lime bags, 4 vibrant gold bags.
bright lavender bags contain 5 shiny teal bags.
posh chartreuse bags contain 4 faded violet bags, 3 pale black bags, 2 posh coral bags.
posh yellow bags contain 5 dim indigo bags.
vibrant yellow bags contain 1 bright orange bag, 1 pale yellow bag, 1 wavy crimson bag, 2 bright crimson bags.
clear bronze bags contain 5 mirrored blue bags.
vibrant purple bags contain 5 clear purple bags.
pale turquoise bags contain 4 muted indigo bags.
wavy aqua bags contain 4 pale brown bags, 3 vibrant silver bags, 3 dotted silver bags, 3 pale maroon bags.
dim green bags contain 4 light tomato bags, 5 drab teal bags, 2 vibrant blue bags.
bright crimson bags contain 2 muted beige bags, 4 muted white bags, 3 plaid lime bags.
wavy yellow bags contain 3 pale gold bags.
pale gray bags contain 1 dotted lime bag, 4 drab magenta bags, 4 shiny indigo bags.
dull orange bags contain 2 dull aqua bags, 5 bright salmon bags, 4 faded lime bags, 2 dull red bags.
wavy lime bags contain 2 faded gray bags, 5 pale aqua bags, 3 mirrored aqua bags.
faded gray bags contain 2 dotted silver bags, 1 posh brown bag.
light gold bags contain 5 plaid turquoise bags, 2 dim indigo bags.
light lime bags contain 3 dark beige bags, 4 clear fuchsia bags, 1 clear beige bag, 3 dotted crimson bags.
muted tomato bags contain 2 drab black bags, 1 dark orange bag, 3 light aqua bags.
vibrant bronze bags contain 4 wavy purple bags, 4 posh coral bags, 2 shiny salmon bags.
posh gray bags contain 2 wavy coral bags, 5 posh salmon bags.
posh bronze bags contain 2 dull teal bags, 1 muted yellow bag.
light cyan bags contain 3 light lavender bags.
shiny purple bags contain 5 drab gray bags.
dim tan bags contain 1 pale black bag.
shiny fuchsia bags contain 3 dark purple bags, 1 striped brown bag, 3 posh indigo bags, 1 dotted crimson bag.
pale red bags contain 2 pale bronze bags.
bright coral bags contain 5 bright salmon bags, 4 vibrant beige bags, 3 bright brown bags.
faded orange bags contain 1 muted brown bag, 2 dark gold bags, 1 posh aqua bag, 5 faded gold bags.
striped beige bags contain 2 striped lavender bags, 3 mirrored maroon bags.
shiny bronze bags contain 5 dim lime bags, 1 mirrored maroon bag, 4 drab bronze bags, 2 striped yellow bags.
muted crimson bags contain 3 mirrored coral bags, 4 light silver bags, 2 shiny gold bags.
faded lavender bags contain 1 shiny indigo bag, 2 light aqua bags.
posh black bags contain 3 muted gold bags.
pale magenta bags contain 2 muted orange bags, 4 muted crimson bags, 4 striped turquoise bags.
striped coral bags contain 1 shiny cyan bag, 2 clear red bags.
clear black bags contain 2 drab brown bags.
drab olive bags contain 5 faded gray bags, 3 plaid silver bags, 5 light maroon bags.
mirrored orange bags contain 1 faded beige bag, 5 plaid turquoise bags.
pale green bags contain 5 dark gold bags, 2 shiny coral bags, 5 striped aqua bags.
dim gray bags contain 1 drab magenta bag.
pale orange bags contain 5 dotted olive bags, 2 posh brown bags, 2 light aqua bags.
wavy white bags contain 2 striped yellow bags, 3 posh bronze bags, 3 faded green bags.
drab bronze bags contain 5 dotted lime bags, 1 dark orange bag, 1 wavy maroon bag, 4 dim brown bags.
mirrored coral bags contain 1 shiny cyan bag, 3 dotted olive bags, 1 faded silver bag, 2 shiny indigo bags.
striped brown bags contain 4 mirrored aqua bags, 2 plaid lime bags, 4 dark gray bags, 4 muted gold bags.
pale gold bags contain 3 mirrored salmon bags, 4 dim fuchsia bags.
dark indigo bags contain 2 bright cyan bags, 1 vibrant olive bag.
drab gray bags contain 2 wavy blue bags, 5 vibrant violet bags, 3 dim lime bags.
vibrant indigo bags contain 4 pale orange bags.
plaid chartreuse bags contain 4 striped tan bags, 4 striped gold bags, 1 muted gray bag, 4 drab teal bags.
faded blue bags contain 4 striped black bags, 3 dark white bags, 4 bright yellow bags.
light chartreuse bags contain 3 wavy coral bags, 5 striped aqua bags, 2 striped red bags.
clear fuchsia bags contain 4 striped crimson bags, 4 muted olive bags, 1 posh tan bag, 2 pale green bags.
bright gold bags contain 5 wavy brown bags, 5 vibrant violet bags, 3 light orange bags, 1 dull plum bag.
light tomato bags contain 3 wavy brown bags, 1 striped crimson bag, 3 clear red bags, 1 mirrored blue bag.
plaid cyan bags contain 3 wavy lavender bags.
shiny turquoise bags contain 5 drab green bags.
wavy gold bags contain 2 pale aqua bags, 1 posh aqua bag, 5 mirrored purple bags, 5 bright salmon bags.
drab lime bags contain 4 dim maroon bags.
dotted indigo bags contain 1 light turquoise bag.
dull turquoise bags contain 2 dim brown bags.
wavy violet bags contain 3 shiny bronze bags, 4 muted maroon bags, 1 shiny green bag.
bright gray bags contain 1 posh coral bag.
mirrored white bags contain 4 dull aqua bags, 5 faded plum bags, 4 dotted salmon bags.
striped aqua bags contain 5 clear gold bags.
light fuchsia bags contain 1 dull teal bag, 2 mirrored fuchsia bags, 2 clear indigo bags.
muted turquoise bags contain 5 vibrant maroon bags, 4 shiny turquoise bags, 3 dotted indigo bags, 5 light maroon bags.
dim black bags contain 4 clear violet bags, 5 clear black bags, 5 light aqua bags, 1 posh coral bag.
dim coral bags contain 2 striped magenta bags, 4 pale white bags, 4 shiny plum bags, 5 drab aqua bags.
mirrored tomato bags contain 4 drab magenta bags, 4 clear purple bags.
dim fuchsia bags contain 5 striped beige bags, 4 muted violet bags, 2 plaid olive bags.
light bronze bags contain 2 mirrored silver bags, 2 light tomato bags, 1 wavy turquoise bag.
muted orange bags contain 3 posh salmon bags.
dark tan bags contain 4 faded magenta bags.
shiny silver bags contain 2 striped lime bags.
clear brown bags contain 1 wavy purple bag, 3 mirrored lime bags.
pale olive bags contain 1 faded silver bag, 3 drab salmon bags, 4 faded gray bags.
dull white bags contain 2 faded violet bags, 5 dim lime bags.
light violet bags contain 5 vibrant purple bags, 4 muted fuchsia bags, 4 striped cyan bags, 5 dull maroon bags.
plaid brown bags contain 4 dark chartreuse bags, 5 shiny red bags, 5 vibrant gray bags.
clear aqua bags contain 1 faded bronze bag.
dark green bags contain 2 dim lavender bags, 4 dull white bags.
dull silver bags contain 1 vibrant red bag, 2 pale lime bags, 5 posh cyan bags.
shiny gray bags contain 5 clear black bags, 3 striped aqua bags, 2 clear gold bags.
pale purple bags contain 5 posh chartreuse bags, 3 mirrored beige bags, 3 faded turquoise bags, 4 vibrant magenta bags.
faded coral bags contain 4 dim cyan bags.
pale cyan bags contain 2 muted violet bags.
dim magenta bags contain 2 shiny turquoise bags, 5 dotted olive bags, 2 clear lime bags, 3 faded bronze bags.
plaid orange bags contain 1 posh crimson bag.
pale black bags contain 3 pale lime bags, 5 dotted silver bags, 1 faded gray bag.
posh tomato bags contain 3 bright silver bags.
bright olive bags contain 5 mirrored maroon bags, 5 dotted blue bags, 1 pale lime bag, 3 mirrored olive bags.
dotted maroon bags contain 5 drab gold bags, 1 wavy purple bag, 1 wavy indigo bag, 5 faded cyan bags.
pale crimson bags contain 2 faded turquoise bags.
muted indigo bags contain 2 posh white bags, 5 pale lime bags, 1 wavy purple bag, 1 vibrant orange bag.
shiny maroon bags contain 1 bright teal bag, 5 dim violet bags.
vibrant black bags contain 4 dull magenta bags.
pale plum bags contain 2 dotted gold bags, 4 muted maroon bags, 1 muted tan bag, 2 vibrant gold bags.
wavy bronze bags contain 3 muted tan bags, 3 bright silver bags.
clear purple bags contain 4 dull bronze bags.
striped black bags contain 5 bright gray bags, 2 dotted crimson bags, 1 bright olive bag, 2 mirrored fuchsia bags.
vibrant brown bags contain 3 dull bronze bags, 3 dim magenta bags.
plaid magenta bags contain 5 dim brown bags.
drab crimson bags contain 1 clear black bag.
mirrored fuchsia bags contain 3 faded salmon bags.
vibrant crimson bags contain 5 plaid gold bags, 5 dull purple bags, 3 mirrored bronze bags, 5 clear white bags.
bright chartreuse bags contain 4 light maroon bags, 5 clear green bags.
dotted tan bags contain 2 dotted purple bags, 1 dark brown bag.
pale teal bags contain 4 muted yellow bags, 5 shiny teal bags.
dim indigo bags contain 5 light olive bags, 3 posh plum bags.
wavy turquoise bags contain 5 dotted crimson bags, 1 vibrant gold bag.
clear salmon bags contain 2 dotted indigo bags, 2 clear beige bags, 2 faded white bags, 3 bright cyan bags.
mirrored violet bags contain 3 pale plum bags, 1 plaid black bag, 4 drab gold bags.
dotted black bags contain 5 light blue bags.
mirrored magenta bags contain 2 pale brown bags, 5 shiny turquoise bags, 1 dotted indigo bag, 1 light maroon bag.
shiny beige bags contain 3 light orange bags, 2 posh black bags.
bright maroon bags contain 5 posh plum bags, 5 mirrored maroon bags.
striped fuchsia bags contain 1 faded indigo bag, 1 posh coral bag, 1 light aqua bag, 5 drab blue bags.
clear gold bags contain 1 pale tan bag, 4 drab brown bags, 4 clear red bags.
light plum bags contain 5 striped bronze bags, 3 light blue bags.
plaid beige bags contain 2 pale gold bags.
dim salmon bags contain 2 shiny plum bags.
vibrant red bags contain 5 dull bronze bags.
dim olive bags contain 5 dull lime bags, 4 mirrored tan bags, 2 drab aqua bags, 4 drab black bags.
striped white bags contain 4 light chartreuse bags.
faded brown bags contain 5 shiny indigo bags, 4 vibrant violet bags, 2 clear chartreuse bags.
wavy orange bags contain 1 mirrored lime bag, 2 light lime bags.
clear violet bags contain no other bags.
drab turquoise bags contain 3 dark magenta bags, 5 dark plum bags.
plaid white bags contain 3 pale gray bags, 3 vibrant lime bags, 4 dotted tomato bags.
dull beige bags contain 5 posh salmon bags, 5 vibrant indigo bags, 4 posh red bags, 1 light tomato bag.
striped cyan bags contain 3 dull gray bags.
vibrant cyan bags contain 1 striped crimson bag.
wavy cyan bags contain 5 dark turquoise bags, 1 plaid lime bag, 5 clear lime bags, 5 pale red bags.
drab aqua bags contain 5 shiny cyan bags, 4 pale bronze bags.
posh violet bags contain 2 dark olive bags, 3 wavy aqua bags.
plaid plum bags contain 2 dark gray bags, 3 dotted bronze bags, 3 faded silver bags.
dim white bags contain 2 dim salmon bags.
plaid red bags contain 4 dull purple bags, 3 dark fuchsia bags, 1 vibrant purple bag.
muted coral bags contain 4 dotted silver bags, 1 posh brown bag, 5 posh chartreuse bags, 3 striped bronze bags.
dark bronze bags contain 5 pale lime bags.
bright tomato bags contain 1 plaid lime bag.
wavy beige bags contain 5 wavy indigo bags.
dark beige bags contain 5 pale lime bags, 1 wavy magenta bag.
striped turquoise bags contain 1 dotted olive bag.
striped olive bags contain 5 bright blue bags, 5 striped salmon bags, 3 drab coral bags.
plaid violet bags contain 3 dull red bags, 3 clear gold bags, 5 shiny gray bags.
posh magenta bags contain 1 vibrant chartreuse bag, 2 dotted fuchsia bags, 3 pale plum bags.
bright brown bags contain 2 dull maroon bags.
pale salmon bags contain 5 dull aqua bags, 4 bright bronze bags.
wavy coral bags contain 2 dull blue bags, 4 vibrant violet bags, 1 clear purple bag, 3 shiny lime bags.
muted magenta bags contain 3 clear violet bags, 5 faded plum bags.
light purple bags contain 1 vibrant indigo bag, 3 drab green bags.
mirrored green bags contain 5 drab cyan bags, 2 bright plum bags.
dull teal bags contain 1 drab aqua bag, 4 dull green bags, 4 faded gray bags, 1 dull bronze bag.
plaid bronze bags contain 4 clear fuchsia bags, 5 posh gold bags, 3 dark olive bags.
dotted turquoise bags contain 1 bright aqua bag, 5 muted black bags.
drab black bags contain 2 vibrant lime bags.
drab red bags contain 2 posh crimson bags.
faded black bags contain 1 light black bag, 3 light silver bags, 5 clear crimson bags, 4 plaid brown bags.
bright aqua bags contain 2 faded salmon bags, 4 vibrant crimson bags, 1 faded orange bag.
dim silver bags contain 4 plaid bronze bags.
dark plum bags contain 1 dark gray bag, 5 muted yellow bags.
shiny teal bags contain 4 dull bronze bags, 3 dim black bags, 1 posh brown bag.
faded chartreuse bags contain 3 pale red bags, 5 drab fuchsia bags, 4 dull green bags, 1 faded blue bag.
clear cyan bags contain 2 shiny olive bags, 1 muted plum bag.
wavy green bags contain 1 dull blue bag.
plaid yellow bags contain 1 drab coral bag.
wavy chartreuse bags contain 2 dull lime bags, 2 mirrored crimson bags, 2 shiny red bags.
dim teal bags contain 2 shiny coral bags, 1 drab magenta bag, 5 dull fuchsia bags.
muted bronze bags contain 3 plaid silver bags, 2 vibrant purple bags, 2 plaid plum bags, 1 vibrant brown bag.
plaid tan bags contain 2 drab magenta bags, 4 clear fuchsia bags.
drab salmon bags contain 1 dim fuchsia bag, 3 muted olive bags, 4 pale lime bags, 5 bright white bags.
wavy indigo bags contain 5 clear tomato bags, 5 mirrored silver bags.
striped maroon bags contain 5 pale gray bags, 4 drab olive bags.
vibrant violet bags contain 3 muted gold bags, 4 posh plum bags, 2 pale tan bags, 2 clear violet bags.
vibrant fuchsia bags contain 3 dim cyan bags, 2 muted crimson bags.
striped chartreuse bags contain 4 clear black bags.
mirrored beige bags contain 1 bright orange bag, 1 posh salmon bag, 4 muted beige bags, 1 mirrored fuchsia bag.
shiny cyan bags contain 3 light aqua bags.
drab chartreuse bags contain 1 vibrant fuchsia bag, 2 clear aqua bags.
light maroon bags contain 3 posh tan bags, 4 faded lavender bags.
bright white bags contain 4 light maroon bags.
vibrant plum bags contain 3 dim blue bags, 2 striped coral bags, 2 bright lime bags, 2 dull tan bags.
posh olive bags contain 5 clear tomato bags.
posh red bags contain 1 pale tan bag.
dark gold bags contain 1 dim black bag.
light beige bags contain 1 mirrored chartreuse bag, 5 bright lavender bags.
dotted white bags contain 3 posh brown bags, 3 faded blue bags, 5 faded cyan bags, 2 faded fuchsia bags.
clear tomato bags contain 1 muted beige bag.
posh white bags contain 3 vibrant lime bags.
shiny green bags contain 5 vibrant salmon bags, 2 dim brown bags, 2 dotted indigo bags.
plaid maroon bags contain 2 posh brown bags, 3 vibrant violet bags, 1 drab coral bag, 5 plaid turquoise bags.
clear yellow bags contain 4 drab aqua bags.
faded tan bags contain 4 striped lavender bags.
wavy red bags contain 3 shiny blue bags.
shiny brown bags contain 3 posh gold bags, 1 bright magenta bag, 1 pale bronze bag, 3 light brown bags.
shiny lime bags contain 1 vibrant olive bag, 4 mirrored fuchsia bags.
bright silver bags contain 1 vibrant green bag, 3 light turquoise bags, 1 light silver bag, 5 dark magenta bags.
pale brown bags contain 5 posh tan bags, 2 light aqua bags, 3 dotted teal bags.
dotted violet bags contain 2 vibrant green bags, 4 posh olive bags, 2 muted tomato bags, 5 wavy bronze bags.
pale blue bags contain 1 striped chartreuse bag, 5 light fuchsia bags.
vibrant tomato bags contain 1 posh red bag, 3 muted beige bags, 3 wavy purple bags.
dull black bags contain 2 bright beige bags.
bright turquoise bags contain 5 faded indigo bags, 3 dull white bags, 1 muted brown bag.
plaid lavender bags contain 5 faded silver bags, 3 clear orange bags.
shiny violet bags contain 5 muted turquoise bags, 1 striped coral bag, 1 dull crimson bag.
striped red bags contain 2 light tomato bags.
dotted salmon bags contain 4 dotted silver bags.
mirrored gold bags contain 3 light yellow bags, 1 drab cyan bag, 2 drab gray bags, 5 posh orange bags.
muted green bags contain 5 mirrored magenta bags, 3 plaid lavender bags, 5 pale fuchsia bags, 1 pale maroon bag.
muted silver bags contain 1 muted tomato bag.
plaid green bags contain 2 striped beige bags, 3 vibrant indigo bags.
muted gray bags contain 4 vibrant olive bags.
light gray bags contain 5 bright white bags, 2 vibrant black bags.
dotted aqua bags contain 3 faded cyan bags, 3 vibrant purple bags.
dull tan bags contain 5 clear purple bags, 3 mirrored maroon bags, 3 dull gold bags, 3 bright turquoise bags.
posh aqua bags contain 3 plaid black bags, 1 drab aqua bag, 2 mirrored fuchsia bags, 1 muted orange bag.
dull cyan bags contain 1 posh tan bag, 1 posh indigo bag.
muted gold bags contain no other bags.
striped tan bags contain 3 light silver bags, 5 dull beige bags, 5 plaid purple bags, 4 muted orange bags.
striped salmon bags contain 1 light olive bag.
dark maroon bags contain 4 striped plum bags, 2 wavy cyan bags, 3 dotted teal bags.
clear green bags contain 3 muted crimson bags.
bright fuchsia bags contain 1 faded cyan bag, 4 muted orange bags, 1 posh black bag, 5 dull bronze bags.
shiny aqua bags contain 4 striped lavender bags, 5 faded indigo bags, 2 pale black bags, 4 vibrant green bags.
posh coral bags contain 2 plaid olive bags, 2 shiny coral bags, 1 vibrant olive bag, 1 clear red bag.
vibrant aqua bags contain 2 drab magenta bags, 3 dotted olive bags, 3 dim plum bags, 2 dotted aqua bags.
faded turquoise bags contain 2 light olive bags, 2 dotted purple bags, 3 faded violet bags.
dark crimson bags contain 2 wavy turquoise bags, 1 shiny red bag, 5 muted white bags.
dull tomato bags contain 2 wavy magenta bags, 4 pale brown bags, 2 dark bronze bags, 1 drab brown bag.
dark coral bags contain 5 dotted black bags, 4 vibrant purple bags, 2 dark bronze bags, 1 vibrant gold bag.
faded beige bags contain 1 plaid brown bag, 3 light silver bags, 5 faded tan bags, 3 mirrored maroon bags.
striped crimson bags contain 5 shiny cyan bags, 3 plaid indigo bags.
pale tan bags contain no other bags.
plaid aqua bags contain 2 mirrored lime bags, 1 posh salmon bag.
muted white bags contain 2 pale red bags, 4 dotted plum bags, 1 posh salmon bag.
light orange bags contain 1 shiny indigo bag, 2 pale lime bags, 5 pale gold bags, 3 clear black bags.
dull purple bags contain 4 wavy turquoise bags, 2 striped coral bags, 1 vibrant violet bag.
dull lavender bags contain 4 dark bronze bags.
clear maroon bags contain 2 clear indigo bags.
striped tomato bags contain 3 muted bronze bags, 5 faded tomato bags, 4 plaid brown bags.
striped gold bags contain 4 shiny indigo bags.
light yellow bags contain 5 pale beige bags.
wavy plum bags contain 4 clear maroon bags, 1 bright brown bag, 1 dim purple bag.
vibrant coral bags contain 5 striped orange bags, 4 muted orange bags, 1 striped blue bag.
light brown bags contain 2 wavy maroon bags, 1 bright beige bag.
dull fuchsia bags contain 5 pale black bags, 1 dotted salmon bag, 5 pale bronze bags, 2 faded silver bags.
dim brown bags contain 1 posh brown bag, 2 shiny cyan bags, 5 shiny indigo bags, 1 striped lavender bag.
dim lime bags contain 5 dim black bags.
muted salmon bags contain 1 bright cyan bag, 1 muted gray bag, 1 plaid silver bag, 3 dotted olive bags.
light red bags contain 5 dark cyan bags, 3 dim red bags, 1 pale olive bag, 5 mirrored crimson bags.
striped blue bags contain 1 mirrored tan bag, 5 vibrant crimson bags, 2 muted turquoise bags.
mirrored lime bags contain 1 mirrored magenta bag, 1 clear purple bag.
pale coral bags contain 1 shiny lime bag, 4 clear bronze bags.
posh plum bags contain 5 faded gray bags.
dull green bags contain 5 mirrored salmon bags, 4 pale green bags, 1 bright purple bag, 5 dark turquoise bags.
pale tomato bags contain 5 shiny white bags.
dark black bags contain 1 faded gold bag, 1 faded aqua bag, 5 drab brown bags, 2 muted tomato bags.
wavy silver bags contain 3 posh brown bags, 3 wavy blue bags, 4 bright white bags.
dotted olive bags contain 1 dotted plum bag, 5 dark orange bags.
faded gold bags contain 5 vibrant gray bags, 1 pale maroon bag, 2 dotted coral bags, 4 bright beige bags.
muted brown bags contain 4 dim black bags.
plaid coral bags contain 5 plaid teal bags.
bright red bags contain 2 posh gray bags, 1 dotted bronze bag, 4 wavy tomato bags, 2 dotted coral bags.
shiny gold bags contain 4 posh coral bags, 2 clear violet bags.
dark gray bags contain 1 vibrant maroon bag, 4 dotted purple bags, 4 mirrored fuchsia bags.
muted teal bags contain 5 muted violet bags, 3 striped aqua bags.
mirrored gray bags contain 3 vibrant lime bags, 4 dull bronze bags, 3 clear indigo bags, 2 drab aqua bags.
wavy crimson bags contain 4 pale gold bags, 4 dotted crimson bags, 4 drab black bags.
shiny magenta bags contain 5 plaid white bags, 4 dull tan bags, 1 clear white bag.
dull coral bags contain 5 light gold bags, 4 dotted green bags.
shiny salmon bags contain 3 pale indigo bags, 4 pale gray bags.
dotted coral bags contain 5 clear red bags, 1 vibrant green bag, 1 dotted crimson bag.
posh salmon bags contain 3 striped lavender bags.
pale white bags contain 2 vibrant red bags, 2 dim turquoise bags, 1 drab white bag, 4 light plum bags.
clear crimson bags contain 3 dotted silver bags, 1 drab red bag, 1 shiny coral bag, 1 mirrored teal bag.
clear orange bags contain 1 striped lavender bag, 5 drab blue bags, 5 dim fuchsia bags.
muted plum bags contain 1 bright olive bag.
dark aqua bags contain 4 mirrored salmon bags, 2 dull fuchsia bags.
pale chartreuse bags contain 2 dark silver bags, 3 drab maroon bags, 1 dull cyan bag.
faded white bags contain 4 faded indigo bags, 4 faded silver bags, 1 muted teal bag.
striped yellow bags contain 1 wavy green bag, 3 plaid tan bags, 2 clear lime bags.
plaid fuchsia bags contain 4 clear beige bags, 2 drab black bags, 5 muted brown bags, 2 striped red bags.
vibrant magenta bags contain 5 bright fuchsia bags, 4 bright plum bags, 5 dotted blue bags, 3 striped fuchsia bags.
dotted fuchsia bags contain 1 muted blue bag, 2 drab plum bags.
plaid indigo bags contain 2 clear black bags, 2 shiny coral bags, 5 dim cyan bags, 2 dotted blue bags.
mirrored teal bags contain 1 dull gold bag.
drab lavender bags contain 2 plaid purple bags.
dull gold bags contain 2 drab brown bags, 5 clear black bags, 5 wavy blue bags, 1 pale black bag.
mirrored silver bags contain 2 dim black bags, 2 shiny gray bags, 1 plaid magenta bag.
mirrored salmon bags contain 1 shiny indigo bag.
mirrored red bags contain 1 plaid gray bag.
mirrored bronze bags contain 4 plaid lime bags, 1 clear fuchsia bag, 5 clear red bags.
striped bronze bags contain 3 dim fuchsia bags, 2 faded bronze bags, 4 drab coral bags, 2 pale indigo bags.
dim red bags contain 5 vibrant indigo bags, 4 shiny gold bags, 5 shiny aqua bags, 3 bright teal bags.
striped plum bags contain 4 light aqua bags, 1 dull beige bag.
faded red bags contain 1 bright lime bag, 3 pale green bags.
clear blue bags contain 1 posh aqua bag, 2 dark green bags, 5 posh maroon bags.
mirrored lavender bags contain 1 shiny gray bag, 5 dotted lime bags, 3 faded tomato bags.
dark lime bags contain 2 pale black bags, 5 mirrored bronze bags, 4 posh olive bags, 3 dull red bags.
muted beige bags contain 2 faded plum bags.
light lavender bags contain 3 posh red bags.
dotted magenta bags contain 5 drab salmon bags, 3 muted orange bags, 4 muted fuchsia bags.
dim blue bags contain 5 striped plum bags, 1 dim brown bag, 3 drab blue bags.
plaid teal bags contain 3 drab salmon bags, 4 muted tan bags, 2 drab blue bags.
drab yellow bags contain 1 faded white bag.
faded aqua bags contain 4 dull olive bags.
dull brown bags contain 5 muted orange bags, 1 bright orange bag, 3 dim teal bags, 1 dotted salmon bag.
light teal bags contain 3 muted chartreuse bags, 5 clear lime bags.
drab fuchsia bags contain 4 dim magenta bags, 3 faded cyan bags, 3 faded bronze bags.
pale lime bags contain 1 vibrant orange bag, 5 dull bronze bags.
muted yellow bags contain 1 clear beige bag, 2 posh chartreuse bags, 5 vibrant lavender bags.
posh green bags contain 2 vibrant red bags, 5 dark olive bags.
dim crimson bags contain 2 drab chartreuse bags, 5 faded aqua bags.
wavy fuchsia bags contain 5 mirrored coral bags.
faded plum bags contain 4 dark red bags, 3 posh red bags, 1 faded indigo bag.
drab plum bags contain 4 pale silver bags, 5 drab fuchsia bags, 3 dark olive bags, 5 wavy maroon bags.
dark yellow bags contain 3 dark white bags, 3 dotted plum bags.
drab magenta bags contain 1 posh salmon bag, 2 mirrored maroon bags.
faded yellow bags contain 4 drab brown bags.
mirrored chartreuse bags contain 2 faded salmon bags, 5 striped lavender bags.
posh crimson bags contain 3 plaid violet bags, 5 dotted coral bags, 4 pale teal bags.
faded purple bags contain 1 clear orange bag, 4 dotted lime bags, 4 muted maroon bags.
clear olive bags contain 1 plaid teal bag.
muted fuchsia bags contain 4 plaid indigo bags, 2 shiny gold bags.
dotted bronze bags contain 4 striped lavender bags, 3 mirrored fuchsia bags, 2 plaid teal bags.
muted chartreuse bags contain 2 bright white bags, 5 faded fuchsia bags, 3 dim lime bags, 1 plaid gold bag.
muted purple bags contain 4 light plum bags, 5 pale indigo bags, 5 mirrored aqua bags.
light blue bags contain 4 posh blue bags.
dark tomato bags contain 2 posh gold bags.
plaid gray bags contain 4 light tomato bags, 4 striped chartreuse bags, 1 muted magenta bag, 3 striped violet bags.
dull crimson bags contain 2 light turquoise bags, 4 shiny cyan bags, 4 posh tan bags, 3 mirrored maroon bags.
bright yellow bags contain 1 muted magenta bag, 4 muted red bags, 5 drab magenta bags.
drab teal bags contain 1 faded salmon bag, 1 dotted crimson bag, 5 dark white bags.
mirrored maroon bags contain 2 muted violet bags, 1 faded silver bag.
mirrored plum bags contain 1 bright chartreuse bag, 4 mirrored purple bags, 1 dim turquoise bag, 4 shiny gold bags.
plaid black bags contain 2 dotted red bags, 2 bright orange bags.
drab beige bags contain 1 plaid gray bag, 2 shiny coral bags, 5 dull white bags.
vibrant tan bags contain 5 dotted salmon bags.
dim yellow bags contain 1 shiny bronze bag, 4 faded plum bags, 4 light blue bags.
bright lime bags contain 2 dull plum bags, 1 posh salmon bag, 5 dark gray bags.
dull violet bags contain 2 plaid salmon bags, 5 dark salmon bags.
posh tan bags contain 1 mirrored aqua bag.
dull indigo bags contain 3 striped yellow bags, 1 dotted black bag, 2 mirrored coral bags.
mirrored cyan bags contain 1 wavy purple bag, 3 drab chartreuse bags.
muted blue bags contain 3 dim olive bags, 5 dim tan bags.
faded green bags contain 1 posh indigo bag, 2 faded magenta bags, 5 pale gold bags, 1 wavy purple bag.
clear red bags contain no other bags.
dark teal bags contain 1 dark turquoise bag, 5 dotted lime bags, 1 dim black bag, 5 vibrant orange bags.
light black bags contain 1 wavy magenta bag, 5 mirrored bronze bags, 3 dotted purple bags, 1 pale yellow bag.
wavy lavender bags contain 4 muted magenta bags, 4 mirrored lime bags.
bright violet bags contain 1 striped violet bag.
dull maroon bags contain 1 shiny coral bag, 2 dull blue bags.
clear turquoise bags contain 1 bright plum bag, 4 wavy olive bags.
dotted lime bags contain 1 dim black bag.
striped magenta bags contain 1 wavy magenta bag, 3 pale red bags, 1 clear white bag.
dim cyan bags contain 3 dotted silver bags, 4 posh black bags, 2 shiny coral bags.
bright orange bags contain 1 muted white bag, 2 posh brown bags, 5 dull green bags.
bright salmon bags contain 3 bright purple bags, 4 dim lime bags, 3 vibrant lavender bags.
dim tomato bags contain 5 striped green bags, 3 drab blue bags, 5 dull salmon bags.
striped orange bags contain 3 faded lime bags.
bright tan bags contain 4 dull turquoise bags, 5 striped gray bags.
plaid gold bags contain 2 dotted plum bags, 5 shiny teal bags.
plaid tomato bags contain 4 vibrant beige bags, 3 dark red bags, 5 dark fuchsia bags.
clear tan bags contain 4 bright aqua bags, 3 wavy tomato bags.
light crimson bags contain 3 plaid black bags.
dotted crimson bags contain 5 drab aqua bags, 4 dim brown bags, 5 dull fuchsia bags, 1 muted violet bag.
wavy maroon bags contain 5 pale tan bags.
shiny chartreuse bags contain 5 dark aqua bags, 5 shiny gray bags, 4 striped orange bags.
posh indigo bags contain 2 striped violet bags, 1 clear tomato bag, 1 vibrant gray bag, 5 striped chartreuse bags.
faded salmon bags contain 2 shiny indigo bags, 5 pale orange bags.
dull blue bags contain 1 posh coral bag, 3 dark gold bags, 1 bright gray bag.
dark red bags contain 2 dotted silver bags.
clear teal bags contain 3 plaid black bags, 1 light tan bag, 2 dark silver bags, 2 dotted beige bags.
dotted green bags contain 5 bright beige bags, 4 posh coral bags, 2 clear aqua bags, 5 faded lavender bags.
wavy brown bags contain 1 faded gray bag, 3 muted violet bags, 4 light silver bags.
clear lime bags contain 3 light tomato bags, 5 striped gold bags, 3 bright gray bags.
dotted purple bags contain 2 faded gray bags, 5 vibrant olive bags, 4 dark gold bags.
dotted teal bags contain 4 vibrant indigo bags, 2 mirrored maroon bags.
shiny red bags contain 2 clear tomato bags, 4 muted crimson bags, 2 plaid gray bags, 1 bright gold bag.
pale indigo bags contain 1 posh chartreuse bag.
drab maroon bags contain 4 drab silver bags, 4 dull gold bags, 1 shiny aqua bag.
pale bronze bags contain 2 light aqua bags.
dark olive bags contain 5 drab magenta bags, 4 muted beige bags.
shiny tomato bags contain 3 dull turquoise bags, 1 dotted lavender bag, 2 posh silver bags, 2 dark blue bags.
dull magenta bags contain 2 faded lime bags, 1 vibrant bronze bag, 3 shiny teal bags.
plaid silver bags contain 2 dim lime bags, 4 drab teal bags, 5 shiny coral bags.
mirrored indigo bags contain 3 drab beige bags.
posh purple bags contain 3 clear fuchsia bags.
drab brown bags contain no other bags.
dim aqua bags contain 1 mirrored coral bag.
wavy magenta bags contain 1 clear gold bag.
light aqua bags contain 5 mirrored maroon bags, 2 dotted plum bags, 3 clear red bags.
dark chartreuse bags contain 2 posh salmon bags, 5 dull bronze bags.
drab white bags contain 5 faded lime bags, 1 shiny green bag, 2 muted teal bags, 1 striped beige bag.
mirrored yellow bags contain 4 dull white bags.
drab blue bags contain 5 muted indigo bags, 1 dim black bag, 4 dotted teal bags, 1 pale gray bag.
faded lime bags contain 1 drab aqua bag, 5 dull bronze bags, 4 dull green bags.
vibrant blue bags contain 1 faded tomato bag, 1 bright olive bag, 3 dotted silver bags, 1 striped lavender bag.
dotted yellow bags contain 3 light olive bags, 4 vibrant salmon bags.
clear coral bags contain 4 faded lavender bags.
posh brown bags contain 3 mirrored maroon bags.
dim chartreuse bags contain 4 posh coral bags.
bright plum bags contain 5 dotted tan bags, 3 light olive bags.
pale beige bags contain 3 posh yellow bags.
dim turquoise bags contain 3 faded chartreuse bags.
vibrant turquoise bags contain 2 plaid turquoise bags, 2 faded violet bags.
wavy blue bags contain 2 dark turquoise bags, 1 striped coral bag, 3 vibrant lime bags, 1 mirrored aqua bag.
striped lime bags contain 2 drab silver bags.
light olive bags contain 3 clear tomato bags.
dotted red bags contain 4 drab orange bags, 1 vibrant olive bag, 5 mirrored coral bags, 1 muted fuchsia bag.
mirrored olive bags contain 5 light turquoise bags.
bright teal bags contain 3 mirrored fuchsia bags, 1 light turquoise bag, 4 striped chartreuse bags, 3 mirrored aqua bags.
posh cyan bags contain 5 dull purple bags, 3 dark orange bags, 5 dull olive bags.
clear magenta bags contain 1 bright purple bag, 3 light tan bags, 3 dull turquoise bags.
bright beige bags contain 2 muted teal bags, 4 dark teal bags, 3 dotted purple bags, 2 posh white bags.
vibrant white bags contain 4 dim white bags.
muted maroon bags contain 2 light orange bags, 1 dim olive bag, 5 striped yellow bags.
light indigo bags contain 4 vibrant green bags, 5 muted chartreuse bags.
dotted gold bags contain 4 bright purple bags.
striped gray bags contain 1 faded aqua bag, 4 wavy red bags, 1 striped plum bag, 3 clear lime bags.
mirrored blue bags contain 3 shiny gray bags, 4 faded cyan bags, 2 wavy magenta bags, 4 shiny coral bags.
dark silver bags contain 3 dull yellow bags, 1 mirrored magenta bag, 3 posh tan bags, 1 bright lavender bag.
striped purple bags contain 5 shiny green bags.
faded violet bags contain 2 dim brown bags.
vibrant gray bags contain 2 light silver bags, 4 dark orange bags, 3 dotted salmon bags, 5 pale lime bags.
muted violet bags contain no other bags.
striped teal bags contain 2 striped yellow bags, 4 plaid beige bags, 4 pale plum bags.
bright magenta bags contain 5 faded blue bags, 2 dotted aqua bags, 2 posh gray bags, 2 muted tan bags.
pale lavender bags contain 1 vibrant plum bag, 3 vibrant lavender bags.
vibrant chartreuse bags contain 1 dim purple bag.
wavy salmon bags contain 2 clear teal bags.
vibrant teal bags contain 2 dark plum bags, 5 striped gray bags.
light tan bags contain 3 bright yellow bags, 1 striped chartreuse bag, 3 posh plum bags, 4 dark magenta bags.
drab orange bags contain 1 wavy purple bag.
plaid salmon bags contain 3 dark olive bags, 4 muted indigo bags, 5 vibrant turquoise bags, 2 striped purple bags.
vibrant beige bags contain 3 pale black bags.
shiny black bags contain 5 plaid black bags, 4 dim brown bags.
muted lime bags contain 1 mirrored maroon bag, 2 shiny red bags, 2 drab gold bags, 5 vibrant chartreuse bags.
mirrored black bags contain 1 shiny salmon bag.
faded indigo bags contain 4 mirrored salmon bags.
vibrant gold bags contain 5 striped gold bags, 5 bright silver bags, 2 dotted purple bags.
shiny olive bags contain 1 clear tomato bag, 3 vibrant tomato bags.
striped lavender bags contain no other bags.
mirrored tan bags contain 4 pale orange bags, 3 plaid olive bags, 5 muted crimson bags, 5 posh salmon bags.
dotted chartreuse bags contain 3 mirrored bronze bags, 2 clear purple bags.
vibrant maroon bags contain 5 faded yellow bags, 4 wavy maroon bags, 1 wavy purple bag.
shiny yellow bags contain 3 mirrored blue bags, 3 faded tan bags, 1 faded beige bag, 4 muted coral bags.
muted black bags contain 2 plaid gold bags, 4 shiny orange bags, 3 clear green bags.
faded cyan bags contain 2 dim brown bags, 1 posh red bag.
shiny crimson bags contain 1 clear maroon bag.
dark white bags contain 5 light olive bags, 5 drab coral bags.
clear white bags contain 4 vibrant olive bags.
vibrant green bags contain 3 dotted plum bags, 2 drab aqua bags, 1 clear gold bag, 5 vibrant indigo bags.
dim plum bags contain 4 striped chartreuse bags, 5 posh salmon bags, 5 mirrored salmon bags, 2 dim teal bags.
dull gray bags contain 4 light maroon bags, 1 plaid tan bag.
posh teal bags contain 4 shiny orange bags, 4 shiny aqua bags, 5 mirrored teal bags.
shiny plum bags contain 2 striped coral bags, 4 drab black bags, 2 muted brown bags.
clear silver bags contain 5 light lavender bags, 5 plaid olive bags.
wavy tan bags contain 3 bright gray bags, 2 dark olive bags, 3 posh fuchsia bags, 4 muted gray bags.
wavy purple bags contain 2 shiny gold bags, 4 mirrored maroon bags.
clear chartreuse bags contain 3 shiny beige bags, 1 mirrored teal bag, 1 dotted coral bag.
dark orange bags contain 1 muted violet bag, 5 shiny indigo bags.
muted olive bags contain 1 vibrant olive bag.
dim lavender bags contain 3 vibrant red bags, 3 vibrant lavender bags, 5 drab orange bags.
dull salmon bags contain 5 shiny blue bags.
dotted orange bags contain 1 faded violet bag, 4 posh gold bags, 1 faded fuchsia bag, 4 muted orange bags.
mirrored purple bags contain 3 vibrant lime bags, 5 dim teal bags.
plaid olive bags contain 3 light silver bags, 1 vibrant violet bag, 2 dotted silver bags, 4 mirrored salmon bags.
dark violet bags contain 2 light magenta bags, 3 wavy magenta bags, 4 light aqua bags, 5 striped lime bags.
pale fuchsia bags contain 1 light turquoise bag, 2 plaid lime bags, 3 dotted white bags, 1 dark red bag.
wavy tomato bags contain 4 striped brown bags, 2 dotted crimson bags, 2 dull bronze bags.
dull olive bags contain 2 clear purple bags.
faded maroon bags contain 5 mirrored brown bags, 3 dull gray bags, 2 clear olive bags.
dark brown bags contain 2 faded silver bags, 3 muted violet bags, 5 shiny teal bags.
clear indigo bags contain 5 muted violet bags, 2 striped beige bags, 5 posh plum bags, 2 clear violet bags.
dim maroon bags contain 5 dotted crimson bags, 3 dotted cyan bags, 4 dim beige bags.
dark fuchsia bags contain 4 clear green bags, 3 plaid green bags.
faded fuchsia bags contain 4 dotted silver bags, 2 clear orange bags, 4 drab green bags.
posh beige bags contain 2 mirrored red bags, 4 light silver bags, 5 dull cyan bags, 4 muted plum bags.
vibrant salmon bags contain 4 posh red bags, 3 faded cyan bags, 1 bright olive bag.
striped green bags contain 5 dim tan bags, 3 dotted purple bags, 2 dotted tan bags, 4 posh gray bags.
drab tomato bags contain 1 plaid aqua bag.
dotted gray bags contain 4 pale salmon bags, 2 shiny crimson bags, 1 dark white bag.
dotted brown bags contain 5 dim green bags.
shiny coral bags contain 2 muted gold bags, 4 vibrant olive bags, 3 clear red bags.
dark magenta bags contain 3 bright purple bags, 2 muted gray bags, 3 faded gray bags, 5 muted teal bags.
vibrant orange bags contain 1 clear gold bag.
plaid turquoise bags contain 2 dark gold bags.
mirrored brown bags contain 2 dark silver bags, 3 clear violet bags, 4 wavy tomato bags.
posh orange bags contain 5 pale orange bags, 5 wavy black bags, 2 dim gray bags, 4 plaid teal bags.
dark blue bags contain 2 faded gray bags, 2 bright purple bags, 2 vibrant beige bags.
dotted plum bags contain 3 striped lavender bags, 2 clear red bags.
vibrant lime bags contain 3 dim fuchsia bags.
dotted lavender bags contain 1 clear black bag, 3 faded gray bags.
muted cyan bags contain 5 bright silver bags.
dull yellow bags contain 4 vibrant salmon bags.
dim purple bags contain 3 pale lime bags, 3 striped yellow bags, 5 light fuchsia bags, 5 pale tan bags.
drab violet bags contain 5 bright fuchsia bags.
posh lime bags contain 5 light salmon bags, 2 dim plum bags.
dark cyan bags contain 1 dim olive bag, 1 plaid turquoise bag.
shiny white bags contain 1 dull tomato bag, 3 dim blue bags, 1 shiny teal bag.
light coral bags contain 3 dotted indigo bags, 2 dim plum bags, 5 clear gold bags, 4 bright crimson bags.
posh lavender bags contain 4 dull olive bags.
dull bronze bags contain 4 dull plum bags.
striped silver bags contain 1 dotted tan bag, 1 vibrant salmon bag, 1 bright yellow bag.
pale violet bags contain 5 dim violet bags, 4 light salmon bags, 5 dark crimson bags.
pale silver bags contain 5 plaid turquoise bags, 4 dull olive bags, 1 drab aqua bag, 2 dotted crimson bags.
posh fuchsia bags contain 3 dark orange bags, 1 bright purple bag, 4 dark turquoise bags, 1 dull fuchsia bag.
mirrored crimson bags contain 1 clear lime bag.
drab purple bags contain 4 clear aqua bags, 1 wavy fuchsia bag, 5 light cyan bags.
dark salmon bags contain 5 faded gray bags.
wavy teal bags contain 5 faded cyan bags.
dull plum bags contain 2 dark gold bags.
clear plum bags contain 1 wavy brown bag, 3 pale salmon bags, 4 dim orange bags, 1 striped magenta bag.
light salmon bags contain 2 faded cyan bags, 3 dim cyan bags, 1 muted fuchsia bag.
dull chartreuse bags contain 5 plaid coral bags, 1 posh maroon bag, 2 dark beige bags.
bright indigo bags contain 4 shiny cyan bags, 4 dark yellow bags, 1 dim blue bag, 2 light beige bags.
muted lavender bags contain 4 faded salmon bags, 3 dark beige bags, 3 dull bronze bags.
drab tan bags contain 2 wavy purple bags, 4 plaid lime bags, 5 vibrant tan bags, 1 dim blue bag.
shiny orange bags contain 3 pale gold bags, 5 vibrant gray bags.
faded silver bags contain no other bags.
plaid lime bags contain 1 posh salmon bag, 1 striped coral bag.
pale aqua bags contain 5 dull magenta bags, 1 wavy green bag.
faded olive bags contain 1 mirrored crimson bag, 4 bright teal bags, 4 mirrored brown bags, 3 plaid tan bags.
dotted cyan bags contain 4 mirrored blue bags, 5 drab aqua bags, 1 pale lavender bag.
faded teal bags contain 1 pale gold bag.
mirrored aqua bags contain 4 striped chartreuse bags, 2 vibrant indigo bags, 4 dark orange bags.
faded crimson bags contain 4 clear red bags, 5 striped lime bags, 2 striped beige bags, 2 plaid beige bags.
drab silver bags contain 2 pale turquoise bags, 1 clear fuchsia bag, 4 faded yellow bags, 3 faded lime bags.
posh blue bags contain 2 plaid gold bags, 2 dark teal bags, 2 dim black bags.
dark purple bags contain 3 wavy maroon bags, 3 dull white bags, 3 dark orange bags, 2 mirrored maroon bags.
muted aqua bags contain 4 bright white bags.
posh gold bags contain 1 vibrant tomato bag, 3 dim lavender bags, 4 pale aqua bags, 3 light brown bags.
dotted silver bags contain 2 mirrored salmon bags, 4 striped lavender bags.
striped violet bags contain 3 mirrored olive bags.
dark turquoise bags contain 1 muted fuchsia bag, 2 pale bronze bags, 2 muted teal bags.
drab coral bags contain 5 bright olive bags, 1 dark red bag, 3 drab magenta bags.
clear lavender bags contain 4 drab orange bags, 5 plaid white bags, 4 pale teal bags.
bright cyan bags contain 4 mirrored maroon bags, 3 light silver bags, 2 shiny indigo bags, 4 light turquoise bags.
plaid blue bags contain 5 dim lavender bags.
plaid purple bags contain 2 mirrored maroon bags, 3 dark magenta bags, 4 dotted indigo bags.
bright black bags contain 3 vibrant black bags.
wavy gray bags contain 3 muted beige bags, 3 dotted coral bags, 2 clear olive bags.
clear gray bags contain 5 dim indigo bags, 3 dotted magenta bags, 5 drab bronze bags, 5 plaid green bags.
shiny tan bags contain 1 dim violet bag, 2 striped coral bags, 1 posh olive bag.
muted red bags contain 1 plaid lime bag.
bright bronze bags contain 2 muted yellow bags, 3 shiny plum bags, 2 vibrant red bags, 4 shiny gray bags.
drab gold bags contain 2 dark tan bags, 1 muted tomato bag, 4 faded tan bags, 4 mirrored lavender bags.
dull aqua bags contain 2 shiny violet bags, 3 dim lavender bags, 4 dim gray bags.
vibrant silver bags contain 1 plaid lime bag, 1 posh tan bag, 2 muted plum bags, 4 shiny green bags.
faded tomato bags contain 2 dotted olive bags, 5 shiny gray bags.
shiny lavender bags contain 5 drab magenta bags, 2 pale green bags, 4 posh green bags, 2 striped aqua bags.
drab indigo bags contain 3 dark coral bags.
pale yellow bags contain 5 muted cyan bags, 2 pale tan bags, 1 muted silver bag.
dim orange bags contain 4 muted plum bags, 4 wavy crimson bags, 3 dim tomato bags.
dim beige bags contain 5 striped red bags, 1 pale orange bag.
drab green bags contain 3 dark red bags, 2 pale orange bags, 5 dull plum bags, 5 faded plum bags.
bright blue bags contain 5 plaid teal bags, 4 muted teal bags, 3 shiny salmon bags, 4 dull red bags.
light silver bags contain 5 striped lavender bags, 2 clear red bags, 2 dotted plum bags.
light white bags contain 3 vibrant indigo bags.
drab cyan bags contain 4 mirrored tomato bags, 3 faded aqua bags, 1 posh gray bag, 1 shiny maroon bag.
vibrant olive bags contain no other bags.
shiny blue bags contain 3 shiny plum bags, 2 dotted red bags, 4 pale bronze bags, 2 drab gray bags.
posh turquoise bags contain 3 dark salmon bags, 2 posh black bags.
posh maroon bags contain 2 pale silver bags, 4 dull crimson bags.
bright green bags contain 2 dotted purple bags, 5 shiny red bags.
pale maroon bags contain 3 bright orange bags, 1 light lime bag, 5 pale red bags.
bright purple bags contain 3 dark red bags, 4 clear indigo bags, 5 mirrored aqua bags.
light turquoise bags contain 5 pale tan bags.
dotted beige bags contain 5 posh blue bags, 4 bright crimson bags, 4 wavy red bags.
muted tan bags contain 3 clear black bags, 2 striped crimson bags, 4 posh tan bags, 5 wavy brown bags.
dim bronze bags contain 5 posh coral bags, 3 wavy lavender bags, 2 dotted coral bags, 1 bright beige bag.
dull red bags contain 4 shiny violet bags, 4 muted beige bags.
light green bags contain 1 dim plum bag, 1 posh bronze bag, 4 plaid olive bags, 3 plaid fuchsia bags.
dotted tomato bags contain 5 dull lime bags, 3 muted tomato bags.
dim violet bags contain 4 light salmon bags, 1 dotted purple bag.
mirrored turquoise bags contain 4 drab gray bags.
posh silver bags contain 4 bright purple bags.
dark lavender bags contain 3 plaid purple bags.
clear beige bags contain 2 vibrant lime bags, 2 muted gold bags, 4 dotted blue bags.
striped indigo bags contain 1 striped fuchsia bag.
dim gold bags contain 2 drab brown bags, 3 mirrored brown bags.
dull lime bags contain 1 dark teal bag.";
}