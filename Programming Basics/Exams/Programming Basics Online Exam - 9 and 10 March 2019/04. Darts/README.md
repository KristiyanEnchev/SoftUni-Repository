﻿
## **Изпит по "Основи на програмирането" – 9 и 10 Март 2019** 
## **Задача 4. Дартс**
Вашата задача е да напишете програма, която да изчислява, дали даден играч е успял да спечели лег. (Лег се нарича единична игра на дартс)

Първоначално играчът **започва с 301 точки**. Играчът хвърля стрелата върху таблото, като за всяко улучено поле, той получава определен брой точки. Всяко поле има по три сектора: **единичен** (**Single**) сектор от който се взимат броят точки от полето. Двоен (**Double**), от него се взимат **удвоените** **точки** от полето и троен (**Triple**) сектор, точките от който са **умножени по 3**.

Получените точки от всеки изстрел се изваждат от началните точки, до достигане на 0.

**Забележка:** При изстрел, даващ повече точки от наличните, той се зачита за неуспешен и играчът трябва да хвърля отново, докато не уцели точки равни на оставащите или по-малки, такъв удар се счита за успешен.

**Пример:** При налични** точки 100, удар даващ повече от 100 точки, неуспешен

При налични точки 100, удар даващ по-малко или равни на 100 точки, успешен
### **Вход** 
Първоначално се чете **един ред**:

- **Името на играча - текст**

**След това до получаване на команда "Retire" се четат многократно по два реда:**

1. **Поле – текст ("Single", "Double" или "Triple")**
1. **Точки – цяло число в интервала [0… 100]**
### **Изход**
Играта приключва при въвеждане на команда "**Retire**" или при изравняване на началните 301 точки към 0. На конзолата трябва да се напечата един ред:

- Ако играчът **е спечелил лега:**
  - **"{името на играча} won the leg with {успешните изстрели} shots."**
- Ако играчът **се е отказал от играта**:
  - **"{името на играча} retired after {неуспешни изстрели} unsuccessful shots."**
### **Примерен вход и изход**

|**Вход**|**Изход**|**Обяснения**|
| :- | :- | :- |
|<p>Michael van Gerwen</p><p>Triple</p><p>20</p><p>Triple</p><p>19</p><p>Double</p><p>10</p><p>Single</p><p>3</p><p>Single</p><p>1</p><p>Triple</p><p>20</p><p>Triple</p><p>20</p><p>Double</p><p>20</p>|Michael van Gerwen won the leg with 8 shots.|<p>Започваме със 301 точки</p><p>Първият удар е тройно 20 -> 60 <= 301</p><p>301 – 60 = 241; успешни изстрели = 1</p><p>Втори удар е тройно 19 -> 57 <= 241</p><p>241 – 57 = 184; успешни изстрели = 2</p><p>Трети удар е двойно 10 -> 20 <=184</p><p>184 – 20 = 164; успешни изстрели = 3</p><p>Четвърти удар е единично 3 -> 3 <= 164</p><p>164 – 3 = 161; успешни изстрели = 4</p><p>Пети удар е единично 1 -> 1 <= 161</p><p>161 – 1 = 160; успешни изстрели = 5</p><p>Шести удар е тройно 20 -> 60 <= 160</p><p>160 – 60 = 100; успешни изстрели  = 6</p><p>Седми удар е тройно 20 -> 60 <= 100</p><p>100 – 60 = 40; успешни изстрели = 7</p><p>Осми удар е двойно 20 -> 40 <=40</p><p>40 – 40 = 0; успешни изстрели = 8</p><p></p>|
|<p>Stephen Bunting</p><p>Triple</p><p>20</p><p>Triple</p><p>20</p><p>Triple</p><p>20</p><p>Triple</p><p>20</p><p>Triple</p><p>20</p><p>Triple</p><p>20</p><p>Double</p><p>7</p><p>Single</p><p>12</p><p>Double</p><p>1</p><p>Single</p><p>1</p>|Stephen Bunting won the leg with 6 shots.|<p>Започваме със 301 точки</p><p>Първият удар е тройно 20 -> 60 <= 301</p><p>301 – 60 = 241; успешни изстрели = 1</p><p>.</p><p>.</p><p>.</p><p>Петият удар е тройно 20 -> 60 <= 61</p><p>61 – 60 = 1; успешни изстрели = 5</p><p>Шестият удар е тройно 20 -> 60 > 1</p><p>Неуспешни изстрели = 1</p><p>Седмият удар е двойно 7 -> 14 > 1</p><p>Неуспешни изстрели = 2</p><p>Осмият удар е единично 12 -> 12 > 1</p><p>Неуспешни изстрели = 3</p><p>Деветият удар е двойно 1 -> 2 > 1</p><p>Неуспешни изстрели = 4</p><p>Десетият удар е единично 1 -> 1 <= 1</p><p>1 – 1 = 0; успешни изстрели = 6</p><p></p>|
|<p>Rob Cross</p><p>Triple</p><p>20</p><p>Triple</p><p>20</p><p>Triple</p><p>20</p><p>Triple</p><p>20</p><p>Double</p><p>20</p><p>Triple</p><p>20</p><p>Double</p><p>5</p><p>Triple</p><p>10</p><p>Double</p><p>6</p><p>Retire</p>|Rob Cross retired after 3 unsuccessful shots.|<p>Започваме със 301 точки</p><p>Първият удар е тройно 20 -> 60 <= 301</p><p>301 – 60 = 241; успешни изстрели = 1</p><p>…</p><p>Пети удар е двойно 20 -> 40 <= 61</p><p>61 – 40 = 21; успешни изстрели = 5</p><p>Шести удар е тройно 20 -> 60 > 21</p><p>Неуспешни изстрели 1</p><p>Седми удар е двойно 5 -> 10 <= 21</p><p>21 – 10 = 11; успешни изстрели 6</p><p>Осми удар е тройно 10 -> 30 > 11</p><p>Неуспешни изстрели 2</p><p>Девети удар е двойно 6 -> 12 > 11</p><p>Неуспешни изстрели 3</p><p>**Retire** -> играча се отказва, след 3 неуспешни изстрела </p><p></p>|


© [Software University Foundation](http://softuni.foundation/). This work is licensed under the [CC-BY-NC-SA](http://creativecommons.org/licenses/by-nc-sa/4.0/) license.

![](04.%20Darts.003.png)   ![](04.%20Darts.003.png)   ![](04.%20Darts.003.png)   ![](04.%20Darts.003.png)   ![](04.%20Darts.003.png)   ![](04.%20Darts.003.png)   ![](04.%20Darts.004.png)   ![](04.%20Darts.003.png)   ![](04.%20Darts.003.png)

Follow us:

Page  PAGE   \\* MERGEFORMAT 2 of  NUMPAGES   \\* MERGEFORMAT 2

Page  PAGE   \\* MERGEFORMAT 2 of  NUMPAGES   \\* MERGEFORMAT 2
