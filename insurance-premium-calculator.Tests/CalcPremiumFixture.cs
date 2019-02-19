using fit;
using insurance_premium_calculator.lib;

namespace insurance_premium_calculator.Tests
{
    public class CalcPremiumFixture : ColumnFixture
    {
        public int age;
        public string gender;
        public InsuranceService testObj = new InsuranceService();

        public double premium() => testObj.CalcPremium(age, gender);
    }
}
