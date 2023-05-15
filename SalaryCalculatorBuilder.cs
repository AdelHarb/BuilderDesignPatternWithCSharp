namespace Builder;

public class SalaryCalculatorBuilder
{
    private int _taxRate = 0;
    private decimal _bonusRate = 0;
    private decimal _educationRate = 0;
    private decimal _transportation = 0;
    private bool _sendPaysLipToEmployee = false;
    private bool _postResultToGL = false;

    public SalaryCalculatorBuilder WithTaxRate(int taxRate)
    {
        _taxRate = taxRate;
        return this;
    }

    public SalaryCalculatorBuilder WithBonusRate(decimal bonusRate)
    {
        _bonusRate = bonusRate;
        return this;
    }

    public SalaryCalculatorBuilder WithEducationRate(decimal educationRate)
    {
        _educationRate = educationRate;
        return this;
    }

    public SalaryCalculatorBuilder WithTransportation(decimal transportation)
    {
        _transportation = transportation;
        return this;
    }

    public SalaryCalculatorBuilder WithSendPaysLipToEmployee(bool sendPaysLipToEmployee)
    {
        _sendPaysLipToEmployee = sendPaysLipToEmployee;
        return this;
    }

    public SalaryCalculatorBuilder WithPostResultToGL(bool postResultToGL)
    {
        _postResultToGL = postResultToGL;
        return this;
    }

    public SalaryCalculator Build()
    {
        return new SalaryCalculator
        (
            _taxRate,
            _bonusRate,
            _educationRate,
            _transportation,
            _sendPaysLipToEmployee,
            _postResultToGL
        );
    }


}
