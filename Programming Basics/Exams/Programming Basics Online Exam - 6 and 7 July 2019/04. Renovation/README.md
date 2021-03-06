﻿
# **Изпит по "Основи на програмирането" – 6 и 7 юли 2019**
## **Задача 4. Ремонт**
Пешо решава, че иска да направи ремонт вкъщи. Неговата задача е да боядиса стените в хола, като знаете **височината** и **ширината** на **една стена.** Холът на Пешо има 4 стени с еднакви размери, определен процент от които се заемат от прозорци и врати, които няма да бъдат боядисвани. Той не е сигурен дали ще успее наведнъж, затова моли Вас да му помогнете да изчисли **дали ще му остава още работа** за следващия ден и, ако да, **колко кв. м. има да довърши**, а в случай, че успее да боядиса хола, колко боя му е останала (трябва да се има предвид, че с **един литър боя се боядисва един квадратен метър** от стената). 
### **Вход**
От конзолата се четат следните редове:

1. Височина на стената - **цяло число** [0… 100]
1. Ширина на стената - **цяло число** [0… 100]
1. Процент от общата площ на стените, който няма да бъде боядисан - **цяло число** [5… 95]
   На следващите редове до получаване на командата "**Tired!**" или докато не бъдат боядисани всички стени, се чете по едно число:
- Литри боя – **цяло число** [0…100]:

**Забележка**: Площта **за боядисване** да бъде закръглена **нагоре** до най-близкото цяло число.
### **Изход**
Да се **отпечата** на конзолата **един** от следните редове:

- При получаване на командата "**Tired!"**:

**"{квадратни метри} quadratic m left."** 
{квадратни метри} е повърхнината, която му остава да боядисана.

- Aко е останала боя в излишък:

**"All walls are painted and you have {литри боя} l**

` `**paint left!"** 

- Aко след боядисването на всички стени, не е останала боя:

**"All walls are painted! Great job, Pesho!"** 
### **Примерен вход и изход** 

|**Вход**|**Изход**|**Обяснения**|
| :-: | :-: | :-: |
|<p>3</p><p>5</p><p>10</p><p>2</p><p>3</p><p>4</p><p>Tired!</p>|45 quadratic m left.|<p>Стената е с височина 3 и ширина 5 </p><p>=> обща повърхнина = 3 \* 5 \* 4 = 60 </p><p>стени за боядисване -> 60 – 10% = 54</p><p>1-во боядисване -> 54 – 2 = 52;</p><p>2-ро -> 52 - 3 = 49</p><p>3-то  -> 49 - 4 = 45</p><p>Вход -> Tired!</p><p>=>останала повърхнина: 45</p><p></p>|
|<p>2</p><p>3</p><p>25</p><p>6</p><p>7</p><p>8</p>|All walls are painted and you have 3 l paint left!|<p>Стената е с височина 2 и ширина 3 </p><p>=> обща повърхнина = 2 \* 3 \* 4 = 24 </p><p>стени за боядисване -> 24 – 25% = 18</p><p>1-во боядисване -> 18 - 6 = 12</p><p>2-ро -> 12 - 7 = 5</p><p>3-то  -> 5 - 8 = -3</p><p>=> всички стени са измазани и ни остават 3 литра боя</p>|


© [Software University Foundation](http://softuni.foundation/). This work is licensed under the [CC-BY-NC-SA](http://creativecommons.org/licenses/by-nc-sa/4.0/) license.

![](04.%20Renovation.003.png)   ![](04.%20Renovation.003.png)   ![](04.%20Renovation.003.png)   ![](04.%20Renovation.003.png)   ![](04.%20Renovation.003.png)   ![](04.%20Renovation.003.png)   ![](04.%20Renovation.004.png)   ![](04.%20Renovation.003.png)   ![](04.%20Renovation.003.png)

Follow us:

Page  PAGE   \\* MERGEFORMAT 2 of  NUMPAGES   \\* MERGEFORMAT 2

Page  PAGE   \\* MERGEFORMAT 2 of  NUMPAGES   \\* MERGEFORMAT 2
