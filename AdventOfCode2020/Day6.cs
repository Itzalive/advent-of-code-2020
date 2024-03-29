﻿namespace AdventOfCode2020;

public class Day6
{
    public static void Part1(string input)
    {
        Console.WriteLine();
        Console.WriteLine("Day6 Part1");

        var groups = input.Split(Environment.NewLine + Environment.NewLine);

        Console.WriteLine(groups.Sum(g => g.Replace(Environment.NewLine, "").Distinct().Count()));
    }

    public static void Part2(string input)
    {
        Console.WriteLine();
        Console.WriteLine("Day6 Part2");
        var groups = input.Split(Environment.NewLine + Environment.NewLine);
        Console.WriteLine(groups.Sum(g => g.Replace(Environment.NewLine, "").Distinct()
            .Count(c => g.Split(Environment.NewLine).All(p => p.Contains(c)))));
    }

    public static string Input = @"gyrf
idg

azedybkmuwgotq
uqztdwasygmb

ljivrzewb
srndxmz
rzbhtge
rzgl

zgxbwupetnlrqhjkc
itbfpruxhkcwzlnoeq
xtrlnkpczewuqhb
nxpczrkhulstqweb

firzbpnk
nfkiz
nfzik
ifkzn
ofkinz

wjcnrhaixfkpqsveby
pxivekfanqbyhjcwsr
newisvxabphcjkqyrf

pugwelohkyjfbcviq
phnjxlweqzfocmyuig
cfgqpeuryhiojwl

bkdnxmyalw
xabwnydk
xynzthwobdk
qedbynukjxwsc
ydbnkwx

viswnyoqkbte
sbywenoiqktr
qsyebntoikw
yneipakwqbsotr

hjrt
veypxkabt
ltgjrd
ntg
qctshgz

bvdlhjsm
lomjbsv
bqjymlvws
bdmjlvsh

a
tav

bcvxtesfuinmjh
rmpiezdybo
kebim

rvh
oj

iph
wehu
chvux
hzlqy
hcw

wpgyzinvcqfjd
cgfniboaud
nshdgfimc
gvdtnfclei

msvpr
vsprim
vmrps
vpsrm

o
l
o
ank

gh
hqg
jrwelgh

mkjfneaytbdulo
voyjhiwgxmza

hskoajyebxt
scetgvkxohabi
sahotkuexbm
wkrqdsbheaxof

t
d
thd
h
n

rqavp
voqcarp
rqavp

ctujizgpdfsyhvlonqxme
msgctnxpzuojvhefldqiy
gmatoyjevuzcnihpfqxdsl

mdtzufi
ygcsnupqvmlob
mkwuz
uhaxme

ytzxmadrlqg
mystocdxlraj

aqtvywkx
ktqnarmiwv
vkqtwa

nhrxoaulqywedpvc
yopvrqlxwuhfncda
mqdhxyarpvocluinw
uxsatqrlcwnhvpdyo

enjrodpvqlmwbtxc
pbxvjtowcldenhmq
dmkcqpnvebwjtxul

lvfmin
mlni
ojmntsil
nmil
nmli

subvoexkqcyftwpnhgji
jkoubfrxvwseqcghpyint
ejycpgokbnxfiqvhwust

o
o

sifjmrtdxgwlqu
gbthemlwpqjr
lavotqynkjzwgrc

prfwzlsbqo
prlzqsfoib
hjyztflbersqp

bk
kfm
k
mk

aucwhbfk
facbhiwujky
fkwdayuehcb
wvkrtfbmuc

gyzumbvnpwhocqj
jbqtavyizfulmch

pagjkcvmxyhitubldeqzofsr
sxyjeikqhabvmfozpl

yqthxfdklpb
kyvqpxfhldt
hkldpxftyq
lhpdtxykfq
ldngypfthkqx

ryfnmplsoqxj
gmjysxpotqlfnr
syflmroqnjpx
snqpymljxfor
boyjxudlampqvzifrskne

lfmtwhpaqjedkixsur
osinhqvyuzmrkdepcjl

ct
htcj
tc
tc

fzhuqmglpjbae
agwkycslhxvnt
hkaglrsy

uovdmec
kmdyvjuaso
giprfomqvhbz

qelmntuoyxwvr
uxyilnwevtko
wtoyxlnuvfae
nlyewokxtquv

qhxsmyrgap
xyahmqzbsor
eqryxsham
rmshuxqay

lcqxhsotrbnekzpdaiugwy
alexgbdqscnoipkuzwthyr
pnrehculbkqfsotwzyaxgid
niwodsepgthaklubrzyxcq

qwpcmxglbszaf
bpgzqawlmfs
rqzfscbmpxlawg
zpsdqfgmlwtab

rvidmhoykf
fyozsivrqweakxm
jmyirokvfcbu

guoqxbysa
ohmgeswxbnp

hevxarygqsfpji
fvherjxsgiqa
hwgfvsijxarq

adjctfpmziw
uchramiqfjbgtsol

nzfalgyoqpsxhbwiketjcvd
djztpoyqmwnarcbvuhlikxsefg

l
l
l
l

eustpacrgnqil
pbjnurlathgqez
lanureqptg
tpgalqkenur

gbmftykqpezwadjs
yjvzpeubdfih

jgbfsdrwuqpci
siwcfurdpbjgq
fcqdwjgubirps
bwsgqjrcpiduf
fwrcgjdspibuq

atoeqpgf
algdpqstf
nhycpfavutqg
qmtaxflpg
kaftigpjqz

rmsnuyx
ysumr
clmyrfus
cfrnymus
ivsqujkrmgy

qhoumzdneyifv
sinrhyezumdvfxoq
dfziomhuyqvelgjn
taymuqhkiowzdnfebvp
cehivoqzdyfmnu

ktnidhjoyfxq
bqsefxcavg

wcxhqvf
hvcxwfq
cbvrqxwf

qs
sq

oujialgb
iuaolgdj
puldjaigo

aptesvmx
vesmtap
epvtajfqcsm
vtpaesm
yasbuvtmpe

netgdzuar
rtugznade
zroaeutndg
dartguenz
dtanrzeug

tcpbzsroklefnqgum
fvpskqwxzhamyelgdi

xyzidvwmlc
wmtxvlcqiyzd
dizymwxclv
iwmvdxlczy

zpuxgdibk
xdygzkibu
dzbgwikxu
zgudikbx

jqvakogwsfym
pmyaosewq

zqsjnximufb
ifndjbqmsz
bjflmznksiq
qjnzibdfmsyk

rotjnygizlfcbuskewvh
sauojklbqnxdwezrv

cytfdombvhxr
iygebrcfhun
qjcbfrhyw
cylfdkbashr

fd
d
d
wd
deg

pvbgnqyaukxzshwf
sjfixcywdq

uqjhovpxrdsbl
guyxokvzitwldrb
fbnavuoxprdel

snobf
bfn
fbn
iefbn

jlaknf
knajgflt
nkfljao
aonkjfl

ixgzmondtcylfwrjkqph
tfjynhxzoimkgcpqdrwl
qizgtmowkcyjrdxlpnfh
nmzdcfwjlkpxqgithroy
xnjtghpwolqmdyczfikr

mtnforek
noktrmef

rcjlpzk
mrlwk
klyrw

bfxpulovhwrg
eolghwyab
ewhzgolmbn
wdelgtmobh

tlkn
qnrom

zdvqybjhsnpwexrtu
ebyjtnhszdlwxvu

dez
tedjz
ezdfxq
zdmne

f
fq
cetd
x

ourfng
wifanuoprg

uebp
gnkbt
btyi
bkjv
bdsfhczqalmr

pty
wb

nlmakqredxhuos
qnuetlhmoxadkrs
lnmasqhudeorxk

ukplmtfqh
hukqmtlif

roydfcupmqi
nyqlihwjecarmp
qpmifzsrbkvtxcgy
qxrvyicmp

woudxiya
dxiauywo
wdxayvoubmi
yaxduwio

vbqeg
g
gz

ihlr
blmj
bml

foxpl
lxpoyt
toplx

ivfu
iuf
bfiuk
qaofiue

zxpqvifbng
zqbfgrix
qjbixzfg
fbxgzkuiqw
fiqbxgz

smo
mos
mos
som

xikr
ghoxidyfjrv
xri

mwuntvkiqdlzyrhfcpegjba
lvnqzakutrhgibyepcmwdjf
cpqfhkrizlejbgxywutmavnd
jhrzvkgwynlcipqdbeftaum

epdgwb
bwgepd
wepbdg

cygzbmivfakohlpseduqwjxnr
cglvwmukednaijspbqofxrzh

bcauqehkxdlgymrinzpso
sfdepcalnjyxthumqbz
ezctdnshwpxylqabumv

ndwbpojtqrcmysxl
kfryzcaxosptjlbdmi
thldpuxcvobyjremsg

xydhuom
ydehxu
hzudyx

ahkiuxjcd
akjhqcud

jksu
rj
jr
jr

fkdr
frdk
rdkf
rfdk

ovqesapgbx
exaspgvq

uihatdx
uieaxht
zthuxia
xtaiuh

ymvwokanzjlqcdfxhipbteu
yjvehfitownxbdklgqaums

rx
rx
rx

qalk
blst
gjwcxly
peizdfnulh

lbsiouyrfwjvamknpc
zqexdu

houmwlgtzp
gupwztoml
muowjlzpgt
tmpwlgzuoj

gjixlvut
kigmvzthdaeybs
tijgvlwcp
givotp

tfbaz
zbtaf
izqgbaft

tlmwrsgduvbjza
adsfukryintb

upgjwafysmv
oeixnbltkd
fuhawvc

uaqshoxiypcdj
tjrlmgwufbay
vatuyejgm

swexo
mxewl
lwxepa
duwzjkxengyf
xamqhew

rtapbujkqowmei
krqwaplejtumi
utdijkaqmhnperw

wcnhsfzkmyeqilupdb
ukcrnbiwxghyzspedlm
epshdunmvryzclkbwi

zcelytf
ezyt

i
i
i
ozvib
i

uwbmlkixdhercgnqoyaz
wxrkglobenicmayqhz
rcyexhnzqwoikmlagb
xcbklqorghwznmiaye

ve
dvsr

ksupnltcxwdbh
okcwxlnsu
lcexnswku
nclwsxkru

dak
akd

fcgijylwr
jgufmeh

ulyizsoarvkwceptjbmhgfdxqn
izyeoagpnwcxmjfutbvrslkdhq
htencgbpfirdxjzmksyvawloqu

ebustwzyiqf
rpb
aglbo
bho
b

brz
z
z
z
z

kvnrgy
vknry
kydvn
gvknqy
vkny

tb
tp
bt
t
t

oifnqlty
ugadmrpchszwvkb

vodrhnaxcqspkt
vdrpnxtshqkoa
npsdrxtvkohqa
hqoptrvnaksdx

b
a

itehmbpogkr
tegrakbohpim
khopmeitgbr
kmgephibrot
bhmgopekrti

pghymvlrtfesnobzdcuw
azmrsflwbthopenducyv
mhoebpzjwulvqnfxksditrcy

em
me
epm
me
me

nalmbtedjx
blckxmte
xbtdle
fygisrxtebl

wmhbjpgkteq
djxmkvqzenfubs

f
f
f

pkotmenbq
yjlasx
rdwfuhzvgci

dltrozycqhpmvae
coaemlyvhqrdt
eolaqyctmdhrv
lhmocfyetqardv
hcermsdqvlayot

hktqw
qv

ewjsvzopmadq
zvtnaqlyorshced

wqxf
tfq
qwimfu

z
z
z
z

ix
y
e

kqgdhpw
gphwjv

frmujkclp
fpjgscklmbur
kupcjrflm
ipclfrkmejdun

sjurlncf
nfcjursl
lnrsfucj
rsnflcju

jzgsw
jzsgw
zwjsg

stngerzp
etksprnz
espzrktn
dnsrptczyfe
srwpnetz

hgijsyp
rnejlfqkzvmo
gjx
pjbi

euwdxcyrt
yurxsdegwcit
wcxderyut

eih
lnay
pizgbf
dbe

eiuhd
diu
iyvud
ihund
udine

sodwj
puzaeyv

dz
zdk
zd

hqacbisnmruxwftjdl
fqkribanucldwjhmxst
jifwxubrcmldntashq
cwdsqmhfbiultxnarj

aufcgbyptlrevdoqxihw
jpciweqanyhtxogldmb

pxwb
xbwp
pwb
wpb
bpwfs

oedzvbgfwmy
oygzxmkef
ymzgirojfe
oegsfmlyz
zgeoyfsm

jiasrghwoycnl
olenjrhycgsaqwi
whsrjcnagyoli
owrhsangjluicyk
lwmshncjdyraogi

vlu
vxu
vu

dsxhqcbzyvogrti
qbxduvoycszhgirtl
dbityavcqsgrohfpm

hopzmudb
mhpza
mphnxzjt
aspghzml

agesxpnitmfu
sinmgepaukftx
xnfgluespamt

ui
ui
ui
ui
ui

jhnitvpbofgrzwux
mdkzvpesowglrjybnx

manj
janmr

gmnyvucx
bpdaxosnr

gaiscflkwb
gaicsflkbdw
sgiacehfwtnklr
kzjaxilsgfwocv

g
p
m

prhlofsgdqnmkyjzxebct
mdrgikvyfsehcjbpzoq
yzeusqijhfbgaorcdpwkm
zhdcoqrskameypbgjf
qfyhrpgkozjsmdbce

zwpt
mgfzhitw
lqbtjkzv
hzyet

svcz
zvsc
zvsc
svcez
vazsc

gvqnwbshut
swtgnvbhqu
vguqshbtwn
nrhvtqsubgw
syhlnqvtgwbu

iflmebyvarw
jzkxdiruyhbvtcgln

pyxrqtckjmnebwi
wtexcmrykqbhz

bsvnzucfrk
knszwm
ynjpheqztkio
kznbc

bu
bur
vub
ub
uvb

nvkojdfgpq
pqkderhatfnlgmu
kofbnpdqcgx

xhwersc
lhmyrx
rygxonh
jqhxpfrtdazk

psxcd
cdqs
hqdsc
cqsd
dcs

djvpifmswcr
ioekyq

lyntud
zlunsqytd
yclvhjdnta
stydmln

atuxelgokzmbydjfvic
oxbjvgifctrpkzdaul
uvhckbxlidojgfzta
idvxakjtogcfhzlub

hmsinyfzljwbqeco
swzlqmfhjyceobin
fweszmlhqynobijc
ohezfbncylwjisqm
fiuqhwcmsjzblnyoe

aehyn
hnvw
jhnv
hnv

ow
vlaerpdk
bfgo

oqud
ojuxd
duao
ugowtdp
udox

jni
g
yht
r
qnp

sqfw
fsqw
fwqs
sfqw

ofparteyjskwhqn
oyprqefwkhnajts
nhorjqtafkepwys

udofztnq
xtuqrnozf
dqtfunobz
dotqfuznb

lsic
otlriay
i
azti
ingpekbv

hgfpqnsdji
krqdpbzs

dqkfaw
ypvxakiuhjn
wake
amskzfl
calkof

nxrbkmvjl
ngeqosyfk

qedbmzvnil
xgsrdyefaokwjct

y
y
y
bk

fmuacvbnekhsj
uchmkbfsejva
iubydmjtkhwefgvas

zdscwrmubj
zcjrs
csjrhz
srzcj
zrsjtc

thbcuqdnzmfpkoeai
nocbtkadmfzieqhp
bocktspdyizwjefqahm

o
o
o
ho
o

wfem
efwm

cmqz
tqmhxw
mq

qkfoncmvaxyejup
suemvjkncfoya
coedxskjnlvfamyuh
eufazictrknvymjgo
fnocvkuamyej

qdlarpwu
irxdawhuel

uchiqmktobedjpw
gcfeyxzs

jqgszhuick
ikgjhzsqcu
uhsjgzcqki

oucamrgjh
eagorujc
aorubcgjvl
aucmjrgo

hylzadntui
hlyeadnkfiujoq

igqkejpbaz
bvhxcwmfklnotsj
egjpqbuk

jansopy
pansyjo
psyonja

lbi
vxb
b

pzgvlauqwsbdh
wdpvtqszlbuh

daeptlomkguirxncqv
awfdnvmbuesixkglrpoq
npxuvqdigarokelm

yz
z
z

npskgzeh
kzeghsp
zkjgqpche
kzhuepg
zkpegh

vxpr
pv
avp
zbvpj
prv

fjkxhemn
zvliyw
pquktmgbr

sum
su
us

sdiufxqhcaz
nzxciqsavgot

rcnyvbthodijekqux
ukaqgdijobetvynch
qcbrejidpohvyktnu
cyqujdtvnbiohekz
mixdwujvsbcnfeyhotkq

inpwsmbyfuxl
isupxmnfbwl
snwlipxfmbu

lmsuedxhkzrqj
qerhwjuzckasp

xzgehoslkf
moxcwfz
iydqjozrpbnuvt

sig
qisg
igs
sig

bcqljwpzuyi
wcyzlpqujbi
wbjpuiczlyvq

shtyjbogacxvdnmi
iktmfcnadjgoyxszh
jihndtosgycxmaw
gytxndwoucijsmah
cgjomnsdayxhti

qvsabyidcn
xonyialqrs
edcnsyzvqpikwatg

l
l
l

dzlwtjsnxkgyiahqefbp
ejtygxbhdszknliwpqfa
sxljzkayhiwgpftdenbq
bnxklhtfsgqejzydpawi
wnsbkaielfxtqdhgyzpj

td
dt
dt
td

dunlzacjkxfwio
jxoluzghecntfkswvda
dvuonefxrazwlqkcj

lj
jl
fjl
lj

jg
gj
jg
gj
jgow

zytownda
ypidatnz
tdzyna
aztysnd

sdpu
dups
psduc

tkrghylamucowf
fkraltcwhoumg
tlkforumgahdcw
ghakclfumortw
ucomwrlgtfkah

i
ipgq
i
i

gtodzkynilx
ckdotngyzxil
zgdokyxtinl
gkyxdtloniz
lsodxypizgktn

fykzoexpqrtm
yqtxprkfmzoeu
rzkqtoyxmpfe
qnxyerkfzotmp

nbcwzkyrsafopglvtxu
zftblnxauvpgykrocs
vsxbkaotpdzulfmcenrgy

cbjpqwxesz
kqmwesjbcvxp
ipsdenrqbwjc

ktjvpuzwi
tikpjvuwz
zutwijkpv
ptikuvzwj

bszcq
rbqwhc
bqcv

dxcekavgultzofhwmrib
fdmgxhoynkeczsr

zxaqerldupyskgbof
nqszfckmupjadebxrovyg

akyo
oay
kaoyx
robady

aqmjfzr
fzjrmaq
frzqmaj

nyiqgcmtolwxkrvfa
ycvifmwxrntazoqke
nmpxicklagfqyrtwov
alcxkiqvofrtwmyn

dregtlhwosqbncj
qcaitoernpdwl
ocnvtlqwrade
edrwcoqnytal

qmiozsepbrwdcvut
rocitbuwpmezdsqv
qeirotzpsumcvwdb
pwosuemvizbdqrtc
tpouqmizbknwdevrsc

cu
c
uc
tc

isdvalzmowphu
adzlimvsuc
ialdmuszv
mctdziuvls
iydvzsgxkulmj

gkcqhmnvedru
dmqknbuv
ibkqnudmv

tbquifjphxgmdy
ypihtfugjxbdqm
mxyuqfigjpdhbt
jmitdhxpzbqfuyg
mdxbtjpfhucgqiy

ye
ygj
nzbyw

xzicukfqrbjyvg
qvuxryfibzkcjg
fijkzxyqbvcgur
yikbgrzujfqxcvh
vcgxbfikjqzyru

pjqmxcrbwlevkz
mhebzwjlkprqxvc
jzmbpwexrlkvqc
kqcvjrpwbzmlxe

xvntlauipyj
afpylivjnt
yaltivpjn

iujp
ipu

rohvzwjmsld
zowlvmrdcx
rdvombliw
wmalydeogrv
dwolvrm

huzksiva
ihvuzkas
uksiahvzd
fuzlkasptivh
akuhdsviz

ieszn
ntkezsc

cwgi
ciwg
gaicw
wicbg
wicg

w
ywc
w
wv
wdm

zowsvmjcbn
szvocjbnwmu
siavwjlcmonhd

lqoyhktfiz
atfyhkqoz
tyfzqhko
zakhyqfote

vo
g
b

q
q
q
q
q

qvbia
aibq
baiq
aqib

c
c
c
c
cb

hlksbft
gftlkbhs
bhyftkls

noljuaqtdzcrp
ucqrzowkyfhtvs
riozcueqft
qzotrhguewc
htxboqcurzk

npy
qp
jpoh

waybxjfupm
exfathbpmju
pxgckazbjfsdomluv

jtxwszgm
hmbdjwg
xsgdwkj
jwg
fqjueywg

iuzdhnfclyroagtexkvpqm
orcgyaitufkpvzqlmhexdn
lyebcogizhvnmafqukdxpsrt
dfumoalhqytvczgnrxpike
lypuemaqgxdtvfnhkciroz

hdgtijpbwonlcaum
ahpwjgtuicblxd
prbejhutdgfclwai

ujskletabhcivfx
vkhlaebujxogqtsc
xsijklvaethfbcu

sghjfxpmya
xfdumpgjha

pqmkonlshf
ewlsofidnmcqzyk
lkafmnsxqo

xjchwm
jomchw

thelwgdkovnfzmjuyqxcib
jsdfgzmktvlcunbyqoh
nvygolqmtbfzhukdcj

sle
eliks
lsbq
svle

hlrsuyotkjmcvbwnqpx
huctkoqvsrnxmwpbjyl
csvmxuhqrwbydgplkijton

ebfykaztums
zfmekhuyb
ibekzuymfn
vzefckmqybupr
mzeksdyfub

znqtghesbp
ufrojtmyspqlwcixvk
phtsazdq

wiafhxgsobktrcvjlmeun
cfsxbnmvhlgwuakojir
nvkbfaomlzcsuhwixjrg

hujpolkysqdmg
dmkgyhpolujs
dirfmgnkopuwsjhyx
mjkapyshduolg

elmbxyostpqi
eqopxiyvulmast
lyxosqmetpi
xolsentpyiqm

e
az
j
j

bayqmsi
ibsayqm

bfnclmvtih
ihlvnmcft
vicmfhlnt
cvolkimthfn
cvtlnifmh

avf
nwbaxy
mplva
la

egjnmwkqiahrflzts
arluynbwemjizskqhtg
ptmswvldnezaojcxrhkgqi
hglwmtizrknsfjqea

nbmtjwr
ntswzjc

tanchrkuoj
ohnujkvtca
naokjcuhtr

nprvjlhaoygtbwzucf
zslbnuycjwvaoirxfhe

calgo
zkcvhqlxuyrojgi
cfeldog
waglcdpto
cgltonb

hpniektlgy
oqiwabgxkry

conl
dcon
obnc
ncjsoi
conad

txqd
drtz
dt
dt

ye
wjey

cgilao
cagiol
ocliga

ncbkimptlfvqzgsyoxr
oslrtybmcgpzfqxvin
olqvzbimpxrftcgsyn
yrpzvclsgxfnqibmot

tdaxubnpsfvjcezyh
rmilkwhgov

a
a
a

nykpfic
pvoyc

bhvpcnq
jvhqbcnp
ncvmpkwqbh

kjs
kjs

mux
xum
xomu
mux

vbaoyigrdhxzuswlnqct
xvsdctrhlunqoyzgabi
qrbtlvfzyjhciaxmsgend
nksbxlgzvdtyihacqr

mntuey
euntym
myneut
yemnxvtu
ytmunze

owgzptuxh
zxhtwgu
xcjztuhwg
azgwtxhu

juz
juzv
juz
juz

gkdc
dckg
gdkc
cdgk
dgck

dwmuhygrbklpac
mrwpagyzuldchbk
brmdyolaeckguwxph
asdhfgqkujvrlbpnywmc
cwmdrgyhlbupak

mnhd
hndm
nmdh
fmnodshv

p
fpvz
p
p

gyuecsmv
uvyxh
pburfnj

tkucsaqn

v
rv
va
v
v

nhzvypaqts
wnkodecmfabsi
rxjhtuvqnglayps

g
r
h
h
r

ybmx
abym
mb
mbi
ybm

johvcuezgtsbpxaimqr
ruevbsmjxhpcoqtzlg

hvysxikeqtdmr
xiyjsk
xbcyaopnuzw

fapzbkletv
bapftvzlk
lvhpkfatbz
lbfypuzkwamtv
kfbavlztp

svaqlpxucmzkrfjohi
ivskuacfrmlqzoxhtpj

knctumya
nctaju
uatjnysbch
tdcxfvnuaeliozwq

dzytih
dtzyhi

ngbrdlfsvpcwohyuq
bgoqflawvrycunhspd
gueyqhfprzivmksldbcnowx
lysqfuthbvrwdocnjapg

guiycvqhbdpzomjwtak
odhmgayvtbuqzwcji

oq
qgb
pqd

yqwm
gteo

ayewhixqouvmgtcb
almuxgfwnqyihtpv
zuvwrxhijmtqy
maxivtqwyhguo

hltcx
ctlh
tlqhc
htcl
htcdal

n
n
fn

wfitcgkp
ipfrswtckg

iukzpvmdsaeg
svexazbgu
jfvexasqhwzgu

feghc
gechfr

i
i

ynkjbfpd
nfvupjmakbd
fjndkpb
jkfpdbn

zws
zgws
zsw

d
d
d
d
d

z
n
l
h
n

gjcyeaznrqu
rayqecgnzuj
gzeyuraqnjc
eczayrnujqg

iocbpjfwlhrxndmsek
owxfhiepmkrlcsjdnb
eshyjbirfpdoaxmvclkw
elbjrougipcwsntmdhfkx

dkeurwgtqn
rgenwdu

tfarceyingkbop
lhjvugpnmykoxrbq
knacpbrzygedosw

kobz
bokn
qflwuebp

dyqwekiruclshg
cryewliukqgds
iuleqgdcyrksw

kdvpq
qvyubfad
etbdpqyv
dqcxrghvs

y
ys

lyhagitc
fnveaw

lsfdjyhmoeu
yfejohulmsd
fjlhyeudsom

mniftya
ijltzbfepsy
itfvkqdy
vifyqt
rtifucy

aonbkfp
rfkomsd
kofc
osfkvj

hbdgrpceyl
hcyreldgv
glcdrehvy
rcgekdhyl

ansgvxpomebrdcl
ovgsrmcdelbxanp
xmdncogrplbvsea
vpawrsgxmenocbdl

ogyzrvwxqh
yrgzkqwuhx
zgxhwuqkyr

nbg
gtnbs

jtnofeiuvlbrmh
zyawocelgk

b
m
b
b
b

rwphas
wrpahs
rwspah
pwrhsa
srhawp

r
r
mre
emr
kngar

uqjawytvifep
aipuewxlfqjt

vklrwcjdgpm
cakmpljdvwr
wpjarkvcmd
cdmtrkvwjebp
wkmcpvdjr

axnklmz
kxaemz
wzdmakb
akmz

ipfabsdv
pdfixquebh
pdjiomwn

belkx
xk
xbk
wkox
knx

ftpdivmrbogczanqyeuwsklxjh
ipzvsrfuaqlkwmyecdbhoxntjg

vabmipqhewtucyg
qictbweuyamvghp
eahovtgyunrwqbzljcdmi
cigvabemqsyuhwt
vxbmkqcyewaihutg

rtjencqvhxdiuwkmsgpbl
ghlsxwidjpbveuctrqk

ykgs
ospkgly
sykg
sgvyexbwqkrj

puh
cusph
hupg
uph

wxtlzho
ixvwrkeztyls
lxabwnozt

jrmycufpowzaiqx
jiypaxfcrqowzum
xqwuyzacoripmfj
yoirjfxqpumcawz
uwqzifxcoryjpam

zacsuygtenfm
jkoxdhbpru

pq
qc

ho
oh

ijcgvnpyb
gvibtnh
nugihvb
ngtvbi

fltdqybv
bdtvqfl

xjfkwshbtyuimzrl
ithlufrmkxzbws
mxrsfkihbzlutw
bicxfmskeuwhgolztrvq

umy
whrk

dxrihokctqbsvgafwzyelmup
egrmfldsbikuyovxhapzqct

g
g
g
t

pfogweznmdxyvji
siofmpejxuyvd

whcrlnt
rlwngc
rlincw
frwnlc
rlcwni

xmoyuwdvcpr
xdvpcurwmyo
upryowcdxmv
vcpmyowdxur
umopxyrdvcw

qstvuiwdbfajrkhx
ukwxjerhibtafvqsd

ne
eun
ne
enrhv

rknzqy
rnqkzy
qryknz
ykzqnr

agh
gp

kqiserftgyzcau
fazkcsiurty
arstyikzcuf

drbvalshq
aqszhbrld
oqjlbescphrdw
hdsblzfrq
stbrgdlvihq

apdbhlmuykeqnvtojcrziwx
jmnvthlrxqikwczyadpoub
gtfwkuhnocvsayzlbmriqpdxj
mlybauezohqcxinjpwtrkvd

kwcgmbvda
sedgu

hatorukz
hotkzrua
otakruzh
atzhkuro
oahzurkt

wl
wz

zotecjdsbpaw
vdhowresjckyt
jidwnslgomuftc

pqdge
tbxnc
ro

vdgtoj
dgvuklfaepnq
togvds
mvgd

rsf
fs
fs
fts

uxonatjihgcdzmeklqf
eatkdufcjgxohiznlms

z
z
z
z

ytfsuvkjzxbcihaq
hecjifgpqbyvtzsa
tjbiqghslmfaveczyd

bmwlvri
fcmavwrxl

zexqgsp
rzbepskaio
epswlz
zspe
uszcenp

tmhqzfcgbslivdeyowknrp
mlwzqdefyjopusnkcigb

zlcrxnupqhswyieatfdjgvkb
pnixsjchyluavwfqkbezgtd
gabdktwpqvfsylinuecxjhz
gkblsjiqfhvedcnytaxurwzp
ublwondvshzgciaxepkjytqf

gcedzrhxkuobalqtim
ruaemtkdzclxbgqho
lheagodbkrxzcqumt

wpkbszjmaytflgiveqcxr
ewfrtpmigxvjacszdqlkby
fncgsytkxqevzblrmaipwj
zjmtebglwqxcvpysiarkf

bnmcpaxwkosl
bnypamrkfltxow

yqnzmcljsop
efakgbrxqcutvd

uzpwcea
cswelb

dautmpvqhwfr
qrldhmbcuovfj

cohmywjnksrxdeli
odcqiupjswrymnkx
jxikhrncyobswlpmdu
skocznixvrwmfyjdta

tpz
zwmajyv

je
ej
jep

qrunyaomvc
amnhrd
wrnamhjfd
knrpjmah
jwmltnra

hrompbgctsjkdxfvaw
orjfpslvhdieckuybxawtm
vhgamztobdxkwsfcprj

kqljpzfdtec
hflcptkbsezdjq
trzfevpidcq

mxesy
y
lvqynah

lbvg
gblv
bvgl

ile
iovbl
rktwizpn
ei

oisu
vsiu
efius
isu
usi

koesljgpc
pjkocsgel
pecgklsjo
pgselkcjo

wktezlndury
ymodglktwnru
riuntydkwl

dcmrauwpt
tikhfbyex
qtoczglnjmvu

o
o
o
o

inwzhfjt
nrzwitgeu
tiwhonz

bweqycjpahrlxzkd
ydqkahcbwjletxpzn
xwzjaqcdyhepkbl
wsijepoqgbfhxlydvckuza
apwqcyxdjzhelbk

bjryus
jubsry
uyrbjgs
jusybri
jsyubr

kwtdph
gzrw
usw
oubw

vpqithk
pviqtkh
qtvkihp
tvpqhik
ktivphqw

gu
l
zl
z

ykmtgcb
dpurenvhwfjsq
ytblazxo

npiujtsxwyelgar
vdesjgxnyipqzalur
ngxalmshbipyrjfec

iwxnahblcyfjkusqogt
qpkozlcuwtyrdjhnabge

zruglboynhdsip
nuvqjlcebpdymtxs
ysubnwdplkf
dyulpsrnab

uqwxagfzmh
fwmugxhqzv
fzhaquxgmw
fuxshmpqgtkznw
hgzwxfmqu

vpahuxrdq
yqrdv

ve
ev

hilmaspcvnqdukrjwtog
pvruhgdnjkwoatqm
hkdmvpowjauqrngt
bhmaogujpvtnqkwdr
qakwmhgrntjupdvof

r
r
r
r

kbfylqr
bjyfqlkr
yfkbqrl

bhfk
gkw

uknilvzmdgsftxjbhea
mxudehajfnkqcsztgiv
wsivtumagyxerznkdfhj
tedicskzaxnugjvmhf

cfjp
pjfc
jcfp
pcfj
pcfj

y
y
y
y

mqcbdapjnzrivlfowkhsxg
fswravokdqzbhmlxicnpj
alofpkxhjvibsczqmnwrd
zqoimsplhnjydwcbxakrfv

wmrpd
wpqdr
zprdfnxu
rpqdk

nh
hn
hn
nh
qndh

pbnkvlt
vplfbx
vlpjbeqys
vlphb
rzvlwpmbi

rnb
rbn
nbr
brn

fxkhea
kafhex
abjgehfkx

eapwslhovimkqdfr
frxpewkqhadvlmois
qdelvaiorkshwpfm

yewquxpoz
ndgtcqiywfe
xwyqoepu

hagocylexukrqtjimnfs
fqrzxnjvwmpkdgo

kowdvbptiseqn
svpqkwxf
aqkpvsmwzul

wdnztvhjgu
nvzujgwthd
huzjvgdnwt
tjwuzghnivd

jhbcusfirekwqotvplmyxz
xflehjqtorbpyiuczvskwm
yrjbluvmciostqhxkezfpw
otshirjuxfzmwqekvyblcp
yirkuxfsembpjatqvohcwlz

obpjmy
opabkjm
jbopm

qhkinmwyzpdla
idatlkhquywvm
dhgwyamklqcin

wlta
dmxzs

d
k
x
d

szfptnyl
tnczeyf

tfpkx
aiqush
fbmtw";
}