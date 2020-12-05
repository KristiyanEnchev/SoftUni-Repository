# Прости проверки – допълнително упражнение

Задачи за допълнително упражнение към курса ["Основи на програмирането" \@
СофтУни](https://softuni.bg/courses/programming-basics).

**Тествайте** решенията си в **judge системата**:
<https://judge.softuni.bg/Contests/Practice/Index/1658#0>

## Тръби в басейн

Басейн с **обем V** има **две тръби** от които се пълни. **Всяка тръба има
определен дебит** (литрите вода минаващи през една тръба за един час).
Работникът **пуска тръбите едновременно** и излиза за **N часа**. Напишете
програма, която изкарва състоянието на басейна, **в момента, когато работникът
се върне.**

### Вход

От конзолата се четат **четири реда**:

-   Първият ред съдържа числото **V – Обем на басейна в литри** – цяло число в
    интервала [1…10000].

-   Вторият ред съдържа числото **P1 – дебит на първата тръба за час** – цяло
    число в интервала [1…5000].

-   Третият ред съдържа числото **P2 – дебит на втората тръба за час**– цяло
    число в интервала [1…5000].

-   Четвъртият ред съдържа числото **H – часовете които работникът отсъства** –
    реално число в интервала [1.0…24.00]

### Изход

Да се отпечата на конзолата **едно от двете възможни състояния**:

-   До колко се е запълнил басейна и коя тръба с колко процента е допринесла.

    -   "**The pool is {запълненост на басейна в проценти}% full. Pipe 1:
        {процент вода от първата тръба}%. Pipe 2: {процент вода от втората
        тръба}%.**"

Aко басейнът се е препълнил – с колко литра е прелял за даденото време**.**

-   "**For {часовете, които тръбите са пълнили вода} hours the pool overflows
    with {литрите вода в повече} liters.**"

### Примерен вход и изход

| **Вход**        | **Изход**                                                | **Обяснения**                                                                                                                                                                                                                      |
|-----------------|----------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| 1000 100 120 3  | The pool is 66.00% full. Pipe 1: 45.45%. Pipe 2: 54.55%. | За 3 часа: Първата тръба е напълнила – 300 л. Втората тръба е напълнила – 360 л. Общо – 660 л. \< 1000 л. =\> 66% са запълнени Първата тръба е допринесла с 45% (300 от 660 л.). Втората тръба е допринесла с 54% (360 от 660 л.). |
| 100 100 100 2.5 | For 2.50 hours the pool overflows with 400.00 liters.    | За 2.5 часа: Първата тръба е напълнила – 250 л. Втората тръба е напълнила – 250 л. Общо – 500 л. \> 100 л. =\> 400 л. са прелели.                                                                                                  |

## Поспаливата котка Том

**Котката Том** обича по цял ден да спи, за негово съжаление стопанинът му си
играе с него винаги когато има свободно време. За да се наспи добре, **нормата
за игра** на Том е **30 000 минути в година.** Времето за игра на Том **зависи
от почивните дни на стопанина му**:

-   Когато е на **работа**, стопанинът му си играе с него **по 63 минути на
    ден**.

-   Когато **почива**, стопанинът му си играе с него **по 127 минути на ден.**

Напишете програма, която въвежда **броя почивни дни** и отпечатва дали **Том
може да се наспи добре** и колко е **разликата от нормата** за текущата година,
като приемем че **годината има 365 дни.**

**Пример**: 20 почивни дни -\> работните дни са 345 (365 – 20 = 245). Реалното
време за игра е 24 275 минути (345 \* 63 + 20 \*127). Разликата от нормата е 5
725 минути (30 000 – 24 275 = 5 725) или 95 часа и 25 минути.

### Вход

Входът се чете от конзолата и се състои от **едно число – броят почивни дни** –
**цяло число** в интервала **[0...365]**

### Изход

На конзолата трябва да се отпечатат **два реда**.

-   Ако времето за игра на Том **е над нормата** за текущата година:

    -   **На първия ред** отпечатайте: **“Tom will run away”**

    -   **На втория ред** отпечатайте разликата от нормата във формат:

        “{H} hours and {M} minutes more for play”

-   Ако времето за игра на Том **е под нормата** за текущата година:

    -   **На първия ред** отпечатайте: **“Tom sleeps well”**

    -   **На втория ред** отпечатайте разликата от нормата във формат:

        “{H} hours and {M} minutes less for play”

### Примерен вход и изход

| **вход** | **изход**                                              | **коментари**                                                                                                                                              |
|----------|--------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------|
| 20       | Tom sleeps well 95 hours and 25 minutes less for play  | Почични дни: 20 \* 127 = 2 540 минути игра Работни дни: 365 - 20 = 345 \* 63 = 21 735 минути игра 30 000 \> 24 274 =\> остават 5725 мин = 95 часа и 25 мин |
| 113      | Tom will run away 3 hours and 47 minutes more for play | Почични дни: 113 \* 127 = 14 351 минути Работни дни: 365 - 113 = 252 \* 63 = 15 876 минути 30 000 \< 30 227 =\> 227 мин повече = 3 часа и 47 мин           |

## Реколта

От **лозе с площ X квадратни метри** се заделя **40% от реколтата за
производство на вино**. От **1 кв.м лозе** се **изкарват Y килограма грозде**.
За **1 литър вино** са **нужни 2,5 кг. грозде**. **Желаното количество вино** за
продан е **Z литра**.

Напишете **програма**, която **пресмята колко вино може да се произведе** и
**дали** това количество **е достатъчно. Ако е достатъчно**, **остатъкът се
разделя по равно между работниците на лозето**.

### Вход

Входът се чете от конзолата и се състои от **точно 4 реда:**

-   1ви ред: **X кв.м е лозето** – **цяло число в интервала [10 … 5000]**

-   2ри ред: **Y грозде за един кв.м** – **реално число в интервала [0.00 …
    10.00]**

-   3ти ред: **Z нужни литри вино** – **цяло число в интервала [10 … 600]**

-   4ти ред: **брой работници** – **цяло число в интервала [1 … 20]**

### Изход

На конзолата трябва да се отпечата следното:

-   Ако **произведеното** вино е **по-малко от нужното**:

    -   **“It will be a tough winter! More {недостигащо вино} liters wine
        needed.”**

        -   **Резултатът трябва да е закръглен към по-ниско цяло число**

-   Ако **произведеното** вино е **повече от нужното**:

    -   **“Good harvest this year! Total wine: {общо вино} liters.”**

        -   **Резултатът трябва да** е **закръглен към по-ниско цяло число**

    -   **“{Оставащо вино} liters left -\> {вино за 1 работник} liters per
        person.”**

        -   **И двата резултата трябва да са закръглени към по-високото цяло
            число**

### Примерен вход и изход

| **вход**       | **изход**                                                                                | **коментари**                                                                                                                                     |
|----------------|------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------|
| 650 2 175 3    | Good harvest this year! Total wine: 208 liters. 33 liters left -\> 11 liters per person. | **Общо грозде**: 650 \* 2 = **1 300**  **Вино** = 40% \* 1300 / 2,5 = **208 208 \> 175** 208 - 175 = **33 л остават** -\> **11 л на човек**       |
| 1020 1.5 425 4 | It will be a tough winter! More 180 liters wine needed.                                  | **Общо грозде**: 1 020 \* 1.5 = **1 530**  **Вино** = 40% \* 1 530 / 2,5 = **244.80 244.80 \< 425** 425 - 244.8 = **180.2 -\> 180 л не достигат** |

## Цена за транспорт

Студент трябва да пропътува **n километра**. Той има избор измежду **три вида
транспорт**:

-   **Такси**. Начална такса: **0.70** лв. Дневна тарифа: **0.79** лв. / км.
    Нощна тарифа: **0.90** лв. / км.

-   **Автобус**. Дневна / нощна тарифа: **0.09** лв. / км. Може да се използва
    за разстояния минимум **20** км.

-   **Влак**. Дневна / нощна тарифа: **0.06** лв. / км. Може да се използва за
    разстояния минимум **100** км.

Напишете програма, която въвежда броя километри **n** и период от деня (ден или
нощ) и изчислява **цената на най-евтиния транспорт**.

### Вход

От конзолата се четат **два реда**:

-   Първият ред съдържа числото **n** – брой километри – цяло число в интервала
    [1…5000]

-   Вторият ред съдържа дума “**day**” или “**night**” – пътуване през деня или
    през нощта

### Изход

Да се отпечата на конзолата **най-ниската цена** за посочения брой километри,
**форматирана до втория знак** след десетичния разделител.

### Примерен вход и изход

| **Вход**  | **Изход** | **Обяснения**                                                                                                                                                                              |
|-----------|-----------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| 5 day     | 4.65      | Разстоянието е под 20 км може да се ползва само **такси**. Началната такса е 0.70 лв. Понеже е през деня, тарифата е 0.79 лв. / км. С такси **цената** е: 0.70 + 5 \* 0.79 = **4.65** лв.  |
| 7 night   | 7.00      | Разстоянието е под 20 км може да се ползва само **такси**. Началната такса е 0.70 лв. Понеже е през нощта, тарифата е 0.90 лв. / км. С такси **цената** е: 0.70 + 7 \* 0.90 = **7.00** лв. |
| 25 day    | 2.25      | Разстоянието е над 20 км може да се ползва **автобус**, но не може да се ползва влак. Автобусът е най-евтиния възможен вариант. С автобус **цената** е: 25 \* 0.09 = **2.25** лв.          |
| 180 night | 10.80     | Разстоянието е над 100 км може да се ползва **влак**. Влакът е най-евтиният възможен вариант за пътуване. С влак **цената** е: 180 \* 0.06 = **10.80** лв.                                 |

## Фирма

**Фирма получава заявка за изработването на проект, за който са необходими
определен брой часове. Фирмата разполага с определен брой дни. През 10% от дните
служителите са на обучение и не могат да работят по проекта. Един нормален
работен ден във фирмата е 8 часа. Всеки служител може да работи по проекта в
извънработно време по 2 часа на ден.**

**Часовете трябва да са закръглени към по-ниско цяло число** (Например –\>
**6.98 часа** се закръглят на **6 часа**).

Напишете програма, която изчислява дали **фирмата може да завърши проекта
навреме** и **колко часа не достигат или остават**.

### Вход

Входът се чете от **конзолата** и съдържа **точно 3 реда**:

-   На **първия** ред са **необходимите часовете** – **цяло число в интервала [0
    ... 200 000]**

-   На **втория** ред са **дните, с които фирмата разполага** – **цяло число в
    интервала [0 ... 20 000]**

-   На **третия** ред е **броят на служителите, работещи извънредно** – **цяло
    число в интервала [0 ... 200]**

### Изход

Да се **отпечата** на конзолата **един ред**:

-   Ако **времето е достатъчно**:

    -   “**Yes!{оставащите часове} hours left.**”

-   Ако  **времето НЕ Е достатъчно**:

    -   “**Not enough time!{недостигащите часове} hours needed.**“

### Примерен вход и изход

| **Вход** | **Изход**                        | **Обяснения**                                                                                                                                                                                                                                                                                                                                                                     |                   |
|----------|----------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------|
| 90 7 3   | Yes!2 hours left.                | За проекта са нужни **90 часа**. Фирмата разполага със **7 дена**. **10%** от които отиват за обучение, следователно часовете за работа са: 6.3 \* 8 = **50.4 часа**. **3 служители работят извънредно** – 3 \* (2 часа за 7 дена) = **42 часа**. **Общо часове** = 50.4 + 42 = **92.4 часа -\> 92 часа \> 90** Проектът **може да бъде завършен на време** и остават **2 часа**. |                   |
| **Вход** | **Изход**                        | **Вход**                                                                                                                                                                                                                                                                                                                                                                          | **Изход**         |
| 99 3 1   | Not enough time!72 hours needed. | 50 5 2                                                                                                                                                                                                                                                                                                                                                                            | Yes!6 hours left. |

## Домашни любимци

Марина обича да пътува. Тя има **3 домашни любимеца** (куче, котка и
костенурка). Когато заминава на пътешествие трябва да съобрази **колко храна да
им остави**, за да **не останат гладни**. Напишете **програма**, която
**пресмята колко килограма храна ще изядат всички** за времето, в което Марина
**отсъства** и **дали оставената храна** от нея ще им **е достатъчна. Всяко
животно** изяжда определено количество храна на ден.

### Вход

От конзолата се четат **пет реда**:

-   Първи ред – **брой дни** – **цяло число** в интервал **[1…5000]**

-   Втори ред – **оставена храна в килограми** – **цяло число** в интервал
    **[0…100000]**

-   Трети ред – храна **на ден за кучето в килограми** – **реално число** в
    интервал **[0.00…100.00]**

-   Четвърти ред – храна **на ден за котката в килограми**– **реално число** в
    интервал **[0.00…100.00]**

-   Пети ред – храна **на ден за костенурката в грамове** – **реално число** в
    интервал **[0.00…10000.00]**

### Изход

На конзолата трябва да се отпечата на **един ред**:

-   Ако оставената храна **Е достатъчна**:

    -   **"{килограма остатък} kilos of food left."**

        -   **Резултатът трябва да е закръглен към по-ниското цяло число**

-   Ако оставената храна **НЕ Е достатъчна**:

    -   **“{килограма недостигат} more kilos of food are needed.”**

        -   **Резултатът трябва да** е **закръглен към по-високото цяло число**

### Примерен вход и изход

| **Вход**         | **Изход**                        | **Обяснения**                                                                                                                                                                                                                                               |
|------------------|----------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| 2 10 1 1 1200    | 3 kilos of food left.            | **Нужна храна за: куче** = 2 дена \* 1 кг = **2кг;**  **котка** = 2 дена \* 1 кг = **2 кг;**   **костенурка** = 2 дена \* 1200 грама = **2.4 кг**; **Общо храна** = 2 + 2 + 2.4 = **6.4**; **6.4 \< 10** =\> 10 - 6.4 = **3.6** -\> **3 кг. храна остават** |
| **Вход**         | **Изход**                        | **Обяснения**                                                                                                                                                                                                                                               |
| 5 10 2.1 0.8 321 | 7 more kilos of food are needed. | **Нужна храна за: куче** = **10.5 кг; котка** = 5 дена \* 0.8 кг = **4 кг; костенурка** = 5 дена \* 321 грама = **1.605 кг**; **Общо храна** = 10.5 + 4 + 1.605 = 1**6.105**; 16.105 – 10 = 6.105 -\> 7 кг не достигат                                      |

## Магазин за цветя

Мария иска **да купи подарък** на сина си. Тя работи в магазин за цветя. В
магазина **идва поръчка** за цветя. Напишете **програма**, която **пресмята
сумата от поръчката** и **дали печалбата е достатъчна за подаръка**. Цветята
имат **следните цени**:

-   **Магнолии** – **3.25** лева

-   **Зюмбюли** – **4** лева

-   **Рози** – **3.50** лева

-   **Кактуси** – **8** лева

От **общата сума**, Мария трябва да **плати 5% данъци**.

### Вход

Входът се **чете от конзолата** и се състои от **5 реда**:

-   **Брой магнолии** – **цяло число** в интервала **[0 … 50]**

-   **Брой зюмбюли** – **цяло число** в интервала **[0 … 50]**

-   **Брой рози** – **цяло число** в интервала **[0 … 50]**

-   **Брой кактуси** – **цяло число** в интервала **[0 … 50]**

-   **Цена на подаръка** – **реално число** в интервала **[0.00 … 500.00]**

### Изход

На конзолата трябва да се **отпечата един ред**.

-   Ако парите **СА стигнали**: "**She is left with {останали} leva.**" – сумата
    трябва да е **закръглена към по-малко цяло число** (**пр. 1.90 -\> 1**).

-   Ако парите **НЕ достигат**: "**She will have to borrow {останали} leva.**" –
    сумата трябва да е **закръглена към по-голямо цяло число** (**пр. 1.10 -\>
    2**).

### Примерен вход и изход

| **Вход**      | **Изход**                       | **Обяснения**                                                                                                                                                                     |
|---------------|---------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| 2 3 5 1 50    | She will have to borrow 9 leva. | **Сума** = 2 \* 3.25 + 3 \* 4 + 5 \* 3.5 + 1 \* 8 = **44 лева Данъци** = 5% от 44 = **2.20**. **Печалба** - **41.80 лева** 50 – 41.80 = **8.20 лева недостигнали**                |
| **Вход**      | **Изход**                       | **Обяснения**                                                                                                                                                                     |
| 15 7 5 10 100 | She is left with 65 leva.       | **Сума** = 15 \* 3.25 + 7 \* 4 + 5 \* 3.5 + 10 \* 8 = **174.25 лева Данъци** = 5% от 174.25 = **8.7125**. **Печалба** - **165.5375 лева** 165.5375 - 100 = **65.54 лева остават** |

# Задачи за шампиони

## Резервоар за гориво

Напишете програма, която познава дали резервоара на едно превозно средство има
нужда от презареждане на горивото или не. От конзолата се четат **два реда** –
**текст и реално число**, на първия ред се чете типа на горивото – текст с
възможности: "**Diesel**", "**Gasoline**" или "**Gas**", а на втория литрите
гориво, които има в резервоара. Ако литрите гориво **са повече или равни на
25**, на конзолата да се отпечата "**You have enough {вида на горивото}.**", ако
**са по-малко от 25**, да се отпечата "**Fill your tank with {вида на
горивото}!**". В случай, че бъде въведено гориво, **различно от посоченото,** да
се отпечата "**Invalid fuel!**".

### Примерен вход и изход

| **Вход**     | **Изход**                   |
|--------------|-----------------------------|
| Diesel 10    | Fill your tank with diesel! |
| Gasoline 40  | You have enough gasoline.   |
| Gas 25       | You have enough gas.        |
| Kerosene 200 | Invalid fuel!               |

**Насоки:** потърсете информация за **вложени условни конструкции**.

## Резервоар за гориво - част 2

Напишете програма, която да изчислява, колко ще струва на един шофьор да напълни
резервоара на автомобила си, като знаете – **какъв тип гориво зарежда, каква е
цената за литър гориво и дали разполага с карта за отстъпки.** Цените на
горивата са както следва:

-   **Бензин – 2.22 лева за един литър,**

-   **Дизел – 2.33 лева за един литър**

-   **Газ – 0.93 лева за литър**

Ако водача има карта за отстъпки, той се възползва от следните **намаления за
литър гориво: 18 ст. за литър бензин, 12 ст. за литър дизел и 8 ст. за литър
газ.**

Ако шофьора е заредил между **20 и 25 литра включително, той получава 8 процента
отстъпка** от крайната цена, **при повече от 25 литра гориво, той получава 10
процента отстъпка** от крайната цена.

### Вход

Входът се **чете от конзолата** и се състои от **3 реда**:

-   **Типа на горивото** – **текст** с възможности: "**Gas**", "**Gasoline**"
    или "**Diesel**"

-   **Количество гориво** – **реално число** в интервала **[1.00 … 50.00]**

-   **Притежание на клубна карта** – **текст** с възможности: "**Yes**" или
    "**No**"

### Изход

На конзолата трябва да се **отпечата един ред**.

-   "**{крайната цена на горивото} lv.**"

    Цената на горивото да бъде форматираната до втората цифра след десетичния
    знак.

### Примерен вход и изход

| **Вход**       | **Изход** | **Обяснения**                                                                                                                                                                                                                                                                                             |
|----------------|-----------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Gas 30 Yes     | 22.95 lv. | Горивото е газ, цена за литър газ е 0.93 лв. Шофьора има карта за отстъпки, отстъпката за газ е 8ст. от цената за литър. Цената на която той ще зареди е 0.93 – 0.08 = 0.85 ст. 30 литра по 0.85 е 25.5 лв. но тъй като при заредени повече от 25 литра има отстъпка. 25.5 – 10% = 22.95 лв. крайна цена  |
| **Вход**       | **Изход** | **Обяснения**                                                                                                                                                                                                                                                                                             |
| Gasoline 25 No | 51.06 lv. | Горивото е бензин, цена за литър бензин е 2.22лв. Шофьора няма карта за отстъпки. 25 литра по 2.22 е 55.50 лв. но тъй като при заредени между 20 и 25 литра включително, има отстъпка. 55.50 – 8% = 51.06 лв. крайна цена                                                                                 |
| Diesel 19 No   | 44.27 lv. | Горивото е дизел, цена за литър дизел е 2.32лв. Шофьора няма карта за отстъпки. 19 литра по 2.33 е 44.27 лв. за това количество гориво няма отстъпки и това остава крайната цена.                                                                                                                         |