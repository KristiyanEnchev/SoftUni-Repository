﻿
# **Изпит по "Основи на програмирането" – 6 и 7 юли 2019**
## **Задача 2. Пазаруване** 
Петър иска да купи **N** видеокарти, **M** процесора и **P** на брой рам памет. Ако броя на видеокартите е **по-голям** от този на процесорите получава **15% отстъпка** от крайната сметка. Важат следните цени:

- Видеокарта – **250 лв./бр**.
- Процесор – **35% от цената на закупените видеокарти/бр**.
- Рам памет – **10% от цената на закупените видеокарти/бр**.

Да се изчисли нужната сума за закупуване на материалите и да се пресметне дали бюджета ще му стигне.
### **Вход**
Входът се състои от четири реда:

1. Бюджетът на Петър - **реално** число в интервала **[0.0…100000.0]**
1. Броят видеокарти - **цяло** число в интервала **[0…100]**
1. Броят процесори - **цяло** число в интервала **[0…100]**
1. Броят рам памет - **цяло** число в интервала **[0…100]**
### **Изход**
На конзолата се отпечатва 1 ред, който трябва да изглежда по следния начин:

- Ако бюджета е достатъчен:

"**You have {остатъчен бюджет} leva left!**"

- Ако сумата надхвърля бюджета:

"**Not enough money! You need {нужна сума} leva more!**"

Резултатът да се форматира до втория знак след десетичната запетая.
### **Примерен вход и изход**

|**Вход**|**Изход**|**Обяснения**|
| :-: | :-: | :-: |
|<p>900</p><p>2</p><p>1</p><p>3</p>|You have 198.75 leva left!|<p>Петър разполага с бюджет 900 лева.</p><p>Купува 2 видеокарти по 250лв., общо 500</p><p>Цената на един процесор е 35% от цената на видеокартите. 35% от 500 е 175лв.</p><p>Той иска да купи само един процесор.</p><p>Цената на един брой рам памет е 10% от цената на видеокартите. 10% от 500 е 50лв.</p><p>Петър иска да купи 3 броя рам памет. <br>3 \* 50 = 150. Общо 500 + 175 + 150 = 825 лв.</p><p>Броя на видеокартите е по-голям от броя на процесорите, затова той получава 15% отстъпка от крайната цена.</p><p>825 – 15% = 701.25 лв.</p><p>701.25 <= 900, парите са му достатъчни и той остава със 198.75лв.</p>|
|<p>920.45</p><p>3</p><p>1</p><p>1</p>|Not enough money! You need 3.92 leva more!||


© [Software University Foundation](http://softuni.foundation/). This work is licensed under the [CC-BY-NC-SA](http://creativecommons.org/licenses/by-nc-sa/4.0/) license.

![](02.%20Shopping.003.png)   ![](02.%20Shopping.003.png)   ![](02.%20Shopping.003.png)   ![](02.%20Shopping.003.png)   ![](02.%20Shopping.003.png)   ![](02.%20Shopping.003.png)   ![](02.%20Shopping.004.png)   ![](02.%20Shopping.003.png)   ![](02.%20Shopping.003.png)

Follow us:

Page  PAGE   \\* MERGEFORMAT 1 of  NUMPAGES   \\* MERGEFORMAT 1

Page  PAGE   \\* MERGEFORMAT 1 of  NUMPAGES   \\* MERGEFORMAT 1