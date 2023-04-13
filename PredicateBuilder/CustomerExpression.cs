using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PredicateBuilder
{
    public class CustomerExpression
    {
        private readonly FilterDto _entity;

        public CustomerExpression(FilterDto entity)
        {
            _entity = entity;
        }
        private Expression<Func<CustomerEntity, bool>> Exp { get; set; } = f => true;
        
        public Expression<Func<CustomerEntity,bool>> CustomExp()
        {
            if (_entity.TC!=null)
            {
                Exp = Exp.And(x => x.TCNumber.StartsWith(_entity.TC));
            }
            if (_entity.Gender!=null)
            {
                Exp = Exp.And(x => x.GenderPDF.Contains(_entity.Gender));
            }
            return Exp;
        }

    }
}
