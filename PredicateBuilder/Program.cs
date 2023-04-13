namespace PredicateBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (CustomerContext context=new())
            {
                //2 ALANA GÖRE
                CustomerExpression _exp = new(new FilterDto()
                {
                    Gender = "E",
                    TC = "7"
                });
                //TEK ALANA GÖRE
                CustomerExpression _exp2 = new(new FilterDto()
                {
                    Gender = "E",
                   
                });
                //VEYA HİÇ ALAN SEÇİLMEMİŞ
                CustomerExpression _exp3 = new(new FilterDto()
                
                    
                );

                var res=     context.Customers.Where(_exp.CustomExp()).ToList();
                var res2 = context.Customers.Where(_exp2.CustomExp()).ToList();
                var res3 = context.Customers.Where(_exp3.CustomExp()).ToList();
              


            }

        }
    }
}