﻿
**Изпит по "Основи на програмирането" - 2 и 3 Май 2019**
## **Задача 6. Ветеринарен Паркинг**
Деси трябва да заведе котката си на ветеринар, но паркингът се заплаща. Напишете програма, която пресмята **колко общо трябва да се плати за престоя на колата** на Деси на паркинга. Паркингът е различен от останалите и има разнообразен ценоразпис. За всеки **четен ден** и **нечетен час**, паркингът таксува **2.50 лева**. Във всеки **нечетен ден** и **четен час** таксата е **1.25 лева**, във **всички останали случаи** се заплаща **1 лев**. Таксуването става на **всеки изминал час от деня**. Всеки един от изходите трябва да бъде закръглен до **втория знак** след десетичната запетая.
### **Вход**
От конзолата се четaт два реда:

- **Брой дни – цяло число** в интервала **[1 … 5]**
- **Брой часове за всеки един от дните - цяло число** в интервала **[1 … 24]**
### **Изход:**
Да се отпечата на конзолата**:**

- За всеки изминал ден, общата сума, която трябва да се плати – **"Day: {индексът на деня} – 
  {общата сума за деня} leva"**
- Когато програмата приключи - **"Total: {общата сума за всички дни} leva"**
### **Примерен вход и изход**

|**Вход**|**Изход**|**Обяснения**|
| :- | :- | :- |
|<p>2</p><p>5</p>|<p>Day: 1 - 5.50 leva</p><p>Day: 2 - 9.50 leva</p><p>Total: 15.00 leva</p>|<p>2 дни по 5 часа за всеки =></p><p>Ден 1 - нечетен, 1вият час също => таксата е равна на 1 лев</p><p>Ден 1, 2рият час е четен => таксата е равна на 1.25 лева</p><p>Ден 1, 3ти час => 1 лев</p><p>Ден 1, 4ти час => 1.25 лева</p><p>Ден 1, 5ти час => 1 лев </p><p>Ден 1 => обща сума – 5.50 лева</p><p></p><p>Ден 2, 1ви час => таксата е равна на 2.50</p><p>…..</p><p>Ден 2 => обща сума – 9.50 лева</p><p></p><p>Обща сума за всички дни => 5.50 + 9.50 = 15.00 лева</p>|
|<p>5</p><p>2</p>|<p>Day: 1 - 2.25 leva</p><p>Day: 2 - 3.50 leva</p><p>Day: 3 - 2.25 leva</p><p>Day: 4 - 3.50 leva</p><p>Day: 5 - 2.25 leva</p><p>Total: 13.75 leva</p>||


© [Software University Foundation](http://softuni.foundation/). This work is licensed under the [CC-BY-NC-SA](http://creativecommons.org/licenses/by-nc-sa/4.0/) license.

![](06.%20Vet%20Parking.003.png)   ![](06.%20Vet%20Parking.003.png)   ![](06.%20Vet%20Parking.003.png)   ![](06.%20Vet%20Parking.003.png)   ![](06.%20Vet%20Parking.003.png)   ![](06.%20Vet%20Parking.003.png)   ![](06.%20Vet%20Parking.004.png)   ![](06.%20Vet%20Parking.003.png)   ![](06.%20Vet%20Parking.003.png)

Follow us:

Page  PAGE   \\* MERGEFORMAT 1 of  NUMPAGES   \\* MERGEFORMAT 1

Page  PAGE   \\* MERGEFORMAT 1 of  NUMPAGES   \\* MERGEFORMAT 1
