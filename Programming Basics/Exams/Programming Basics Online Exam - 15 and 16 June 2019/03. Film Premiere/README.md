﻿
# **Изпит по "Основи на програмирането" - 15 и 16 юни 2019**
## **Задача 3. Филмова премиера**
За предстояща премиера на три известни продукции, местно кино ви наема да напишете софтуер, който да изчислява цената, която клиентите трябва да заплатят, според филма и пакета, който са избрали.

||**John Wick**|**Star Wars**|**Jumanji**|
| :-: | :-: | :-: | :-: |
|**Напитка**|12 лв./бр.|18 лв. /бр.|9 лв. /бр.|
|**Пуканки**|15 лв. /бр.|25 лв. /бр.|11 лв. /бр.|
|**Меню**|19 лв. /бр.|30 лв. /бр.|14 лв. /бр.|
Напишете програма, която **изчислява** цената, която трябва да се заплати, като имате в предвид следните отстъпки**:**

- При избран филм "**Star Wars**" и закупени **поне** **четири** билета, има 30% семейна отстъпка.
- При избран филм "**Jumanji**" и закупени **точно** **два** билета, има 15% отстъпка за двама.
### **Вход**
Входът се чете от конзолата и се състои от **три реда**:

- **Първи ред** - **прожекция -** **текст с възможности**"**John Wick**"**,** "**Star Wars**" **или** "**Jumanji**"
- **Втори ред - пакет за филм - текст  с възможности** "**Drink**", "**Popcorn**" **или** "**Menu**"
- **Трети ред - брой билети - цяло число в интервала [1… 30]**
### **Изход**
На конзолата трябва да се отпечата **един ред**:

"**Your bill is {крайна цена} leva.**"

**Цената да бъде закръглена до втората цифра след десетичния знак.**
### **Примерен вход и изход**

|**Вход**|**Изход**|**Обяснения**|
| :- | :- | :- |
|<p>John Wick</p><p>Drink</p><p>6</p>|Your bill is 72.00 leva.|Филмът е John Wick избрана е напитка. Цена за един билет е 12 лв. 6 билета по 12 лв.  -> 72 лв. Няма отстъпки |
|<p>Star Wars</p><p>Popcorn</p><p>4</p>|Your bill is 70.00 leva.|<p>Филмът е  Star Wars избрани са пуканки.</p><p>Цена за един билет е 25 лв. 4 билета по 25 лв. -> 100 лв. За този филм има 30% отстъпка при 4 или повече човека. 30% от 100 -> 30 100 – 30 -> 70 лв. крайна цена</p>|
|<p>Jumanji</p><p>Menu</p><p>2</p>|Your bill is 23.80 leva.|<p>Филмът е  Jumanji избрано е меню(напитка + пуканки).</p><p>Цена за един билет е 14 лв. 2 билета по 14 лв. -> 28 лв. За този филм има 15% отстъпка при точно 2 човека. 15% от 28 -> 4.20 <br>28 – 4.20 лв. -> 23.80 лв.  крайна цена</p>|



© [Software University Foundation](http://softuni.foundation/). This work is licensed under the [CC-BY-NC-SA](http://creativecommons.org/licenses/by-nc-sa/4.0/) license.

![](03.%20Film%20Premiere.006.png)   ![](03.%20Film%20Premiere.006.png)   ![](03.%20Film%20Premiere.007.png)   ![](03.%20Film%20Premiere.007.png)   ![](03.%20Film%20Premiere.007.png)   ![](03.%20Film%20Premiere.006.png)   ![](03.%20Film%20Premiere.006.png)   ![](03.%20Film%20Premiere.006.png)   ![](03.%20Film%20Premiere.007.png)

Follow us:

Page  PAGE   \\* MERGEFORMAT 2 of  NUMPAGES   \\* MERGEFORMAT 2

Page  PAGE   \\* MERGEFORMAT 2 of  NUMPAGES   \\* MERGEFORMAT 2