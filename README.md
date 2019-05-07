
Write a C# console program that would be used by the counter salesperson to print out the
invoice slip.
Your program should read the following information from the console:
- a. Item Code (string)
- b. Item Price (decimal)
- c. Item Quantity (integer)
- d. Is the shopper a loyalty member? (char – Y/N)
- e. Membership Number [to be input if response to (d) is Y]

TIPS: The program should:
- Prompt for Item data (Item Code, Item Price, Item Quantity).
- After reading the data, if sales person enters ‘Y’, accept data for the next item.
- Repeat above process for all the items.
- For programming purpose if you intend using arrays, you can make appropriate
  assumption on the maximum array size.
- Compute the cost for each item and print each item’s detail (eg. midweek discount
  and total price).
- Also compute and print the gross total, membership discount, GST and payment
  amount at the bottom of the invoice slip (as per the format shown in annexure).

You may assume:-
i. The counter salesperson would enter all the data correctly and hence your program
   need not perform input data validations.
ii. You are permitted to use the ISS.RV.LIB libraries for reading the data input from
    console.

Your answer should include:-
- You are expected to write a static class with a main method that would perform the
  above task. You need not demonstrate OOP approach for this question.
- A syntactically correct program that meets the specifications is essential.
- In addition credit would be given if you are able to accomplish the followings:
- Organize your program modularly with appropriate static methods.
- Demonstrate ability to format the invoice slip well.
- Demonstrate best practices such as using good naming standards and clear
  presentation of program.
  
  
  
  ABC Store is a popular shop that sells a range of items like groceries, fresh food, stationery
  and other household items. Like most shops of this type they have a personal computer at the
  sales counter which the salesperson uses for the purpose of preparing invoices. When a
  customer approaches for payment, the salesperson refers to the label in the items that the
  shopper brings and enters the item code, price and quantity for each item. Once the data entry
  is complete computer program prints the invoice as shown in the input/output format (ref fig
  A.1, fig A.2, fig A.3 & fig A.4).
  Discounts & Computation specifications:
  ABC Store offers two types of discount. First type of discount is the membership discount.
  Shoppers who have signed up as a “member” receive a discount of 10% on the gross total.
  The second type of discount is given to all shoppers (whether they are member or not). This
  is called mid-week discount and is applicable for all food items purchased on Wednesdays.
  All food items are sold at a discount of 20%. As per the codification system all food items
  have item codes starting with the letter “F”. The customer also pays a GST @ 7% on the net
  amount (i.e., Gross Total – Discounts).



