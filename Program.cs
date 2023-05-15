// See https://aka.ms/new-console-template for more information
using Builder;

var builder = new SalaryCalculatorBuilder();

builder.WithBonusRate(0.1m)
    .WithEducationRate(0.05m)
    .WithPostResultToGL(true)
    .WithSendPaysLipToEmployee(true)
    .WithTaxRate(10)
    .WithTransportation(0.05m);
//Notice here we set the values for the builder but we didn't use the Build() method to create the object.
//So we have the luxury of changing the values before we create the object or even not creating the object at all.

var calculator = builder.Build();
//now we have the calculator object with the values we set in the builder.