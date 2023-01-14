using Application.Interfaces.Attributes;
using Application.Interfaces.Services;
using Domain.Common;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class EntityMapperService : IEntityMapperService
    {
        public TEntity MapValues<TEntity>(TEntity entity, TEntity newValue)
        {
            IList<string> ignoredProperties = IgnoredProperties();
            var entityPropertyInfos = entity.GetType().GetProperties();
            var newValuePropertyInfos = newValue.GetType().GetProperties();
            try
            {
                for (int i = 0; i < newValuePropertyInfos.Length; i++)
                {
                    bool isContainIgnoredProp = ignoredProperties.Contains(newValuePropertyInfos[i].Name);
                    bool isSimilarValue = newValuePropertyInfos[i].GetValue(entity) == entityPropertyInfos[i].GetValue(newValue);
                    if (!isContainIgnoredProp && !isSimilarValue)
                        entityPropertyInfos[i].SetValue(entity, newValuePropertyInfos[i].GetValue(newValue));
                }

                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private IList<string> IgnoredProperties()
        {
            IList<string> propertyNames = new List<string>();
            PropertyInfo[] auditableEntityPropertyInfos = typeof(AuditableEntity).GetProperties();
            foreach (PropertyInfo property in auditableEntityPropertyInfos)
                propertyNames.Add(property.Name);

            return propertyNames;
        }
    }
}
