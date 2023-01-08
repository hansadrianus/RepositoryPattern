using Application.Interfaces.Attributes;
using Application.Interfaces.Services;
using LinqKit;
using System.Linq.Expressions;
using System.Reflection;

namespace Infrastructure.Services
{
    public class QueryBuilderService : IQueryBuilderService
    {
        private readonly MethodInfo StringContainsMethod = typeof(string).GetMethod(@"Contains", BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(string) }, null);
        private readonly MethodInfo BooleanEqualsMethod = typeof(bool).GetMethod(@"Equals", BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(bool) }, null);
        private readonly MethodInfo Int16EqualsMethod = typeof(short).GetMethod(@"Equals", BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(short) }, null);
        private readonly MethodInfo Int32EqualsMethod = typeof(int).GetMethod(@"Equals", BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(int) }, null);
        private readonly MethodInfo Int64EqualsMethod = typeof(int).GetMethod(@"Equals", BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(long) }, null);
        private readonly MethodInfo Uint16EqualsMethod = typeof(float).GetMethod(@"Equals", BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(float) }, null);
        private readonly MethodInfo Uint32EqualsMethod = typeof(double).GetMethod(@"Equals", BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(double) }, null);
        private readonly MethodInfo Uint64EqualsMethod = typeof(decimal).GetMethod(@"Equals", BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(decimal) }, null);
        private readonly MethodInfo DateTimeEqualsMethod = typeof(DateTime).GetMethod(@"Equals", BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(DateTime) }, null);

        public Expression<Func<TDbType, bool>> BuildPredicate<TDbType, TSearchCriteria>(TSearchCriteria searchCriteria)
        {
            var predicate = PredicateBuilder.True<TDbType>();
            var searchCriteriaPropertyInfos = searchCriteria.GetType().GetProperties();
            foreach (var searchCriteriaPropertyInfo in searchCriteriaPropertyInfos)
            {
                var dbFieldName = GetDbFieldName(searchCriteriaPropertyInfo);
                var dbType = typeof(TDbType);
                var dbFieldMemberInfo = dbType.GetMember(dbFieldName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance).Single();

                if (searchCriteriaPropertyInfo.Name.Contains("GreaterThan"))
                {
                    if (searchCriteriaPropertyInfo.PropertyType == typeof(short?))
                        predicate = ApplyInt16Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(int?))
                        predicate = ApplyInt32Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(long?))
                        predicate = ApplyInt64Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(float?))
                        predicate = ApplyUint16Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(double?))
                        predicate = ApplyUint32Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(decimal?))
                        predicate = ApplyUint64Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(DateTime?))
                        predicate = ApplyDateTimeCriterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">");
                }
                else if (searchCriteriaPropertyInfo.Name.Contains("GreaterThanEqual"))
                {
                    if (searchCriteriaPropertyInfo.PropertyType == typeof(short?))
                        predicate = ApplyInt16Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">=");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(int?))
                        predicate = ApplyInt32Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">=");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(long?))
                        predicate = ApplyInt64Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">=");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(float?))
                        predicate = ApplyUint16Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">=");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(double?))
                        predicate = ApplyUint32Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">=");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(decimal?))
                        predicate = ApplyUint64Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">=");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(DateTime?))
                        predicate = ApplyDateTimeCriterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, ">=");
                }
                else if (searchCriteriaPropertyInfo.Name.Contains("LessThan"))
                {
                    if (searchCriteriaPropertyInfo.PropertyType == typeof(short?))
                        predicate = ApplyInt16Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(int?))
                        predicate = ApplyInt32Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(long?))
                        predicate = ApplyInt64Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(float?))
                        predicate = ApplyUint16Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(double?))
                        predicate = ApplyUint32Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(decimal?))
                        predicate = ApplyUint64Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(DateTime?))
                        predicate = ApplyDateTimeCriterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<");
                }
                else if (searchCriteriaPropertyInfo.Name.Contains("LessThanEqual"))
                {
                    if (searchCriteriaPropertyInfo.PropertyType == typeof(short?))
                        predicate = ApplyInt16Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<=");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(int?))
                        predicate = ApplyInt32Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<=");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(long?))
                        predicate = ApplyInt64Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<=");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(float?))
                        predicate = ApplyUint16Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<=");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(double?))
                        predicate = ApplyUint32Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<=");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(decimal?))
                        predicate = ApplyUint64Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<=");
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(DateTime?))
                        predicate = ApplyDateTimeCriterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate, "<=");
                }
                else
                {
                    if (searchCriteriaPropertyInfo.PropertyType == typeof(string))
                        predicate = ApplyStringCriterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate);
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(bool?))
                        predicate = ApplyBoolCriterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate);
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(short?))
                        predicate = ApplyInt16Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate);
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(int?))
                        predicate = ApplyInt32Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate);
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(long?))
                        predicate = ApplyInt64Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate);
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(float?))
                        predicate = ApplyUint16Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate);
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(double?))
                        predicate = ApplyUint32Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate);
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(decimal?))
                        predicate = ApplyUint64Criterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate);
                    else if (searchCriteriaPropertyInfo.PropertyType == typeof(DateTime?))
                        predicate = ApplyDateTimeCriterion(searchCriteria, searchCriteriaPropertyInfo, dbType, dbFieldMemberInfo, predicate);
                }
            }

            return predicate;
        }

        private Expression<Func<TDbType, bool>> ApplyStringCriterion<TDbType, TSearchCriteria>(TSearchCriteria searchCriteria, PropertyInfo searchCriterionPropertyInfo, Type dbType, MemberInfo dbFieldMemberInfo, Expression<Func<TDbType, bool>> predicate, string condition = "==")
        {
            var searchString = searchCriterionPropertyInfo.GetValue(searchCriteria) as string;
            if (string.IsNullOrWhiteSpace(searchString))
                return predicate;

            var dbTypeParameter = Expression.Parameter(dbType, @"x");
            var dbFieldMember = Expression.MakeMemberAccess(dbTypeParameter, dbFieldMemberInfo);
            var criterionConstant = new Expression[] { Expression.Constant(searchString) };
            var expression = GetExpression(dbFieldMember, StringContainsMethod, criterionConstant, condition);
            var lambda = Expression.Lambda(expression, dbTypeParameter) as Expression<Func<TDbType, bool>>;

            return predicate.And(lambda);
        }

        private Expression<Func<TDbType, bool>> ApplyBoolCriterion<TDbType, TSearchCriteria>(TSearchCriteria searchCriteria, PropertyInfo searchCriterionPropertyInfo, Type dbType, MemberInfo dbFieldMemberInfo, Expression<Func<TDbType, bool>> predicate, string condition = "==")
        {
            var searchBool = searchCriterionPropertyInfo.GetValue(searchCriteria) as bool?;
            if (searchBool == null)
                return predicate;

            var dbTypeParameter = Expression.Parameter(dbType, @"x");
            var dbFieldMember = Expression.MakeMemberAccess(dbTypeParameter, dbFieldMemberInfo);
            var criterionConstant = new Expression[] { Expression.Constant(searchBool) };
            var expression = GetExpression(dbFieldMember, BooleanEqualsMethod, criterionConstant, condition);
            var lambda = Expression.Lambda(expression, dbTypeParameter) as Expression<Func<TDbType, bool>>;

            return predicate.And(lambda);
        }

        private Expression<Func<TDbType, bool>> ApplyInt16Criterion<TDbType, TSearchCriteria>(TSearchCriteria searchCriteria, PropertyInfo searchCriterionPropertyInfo, Type dbType, MemberInfo dbFieldMemberInfo, Expression<Func<TDbType, bool>> predicate, string condition = "==")
        {
            var searchShort = searchCriterionPropertyInfo.GetValue(searchCriteria) as short?;
            if (searchShort == null)
                return predicate;

            var dbTypeParameter = Expression.Parameter(dbType, @"x");
            var dbFieldMember = Expression.MakeMemberAccess(dbTypeParameter, dbFieldMemberInfo);
            var criterionConstant = new Expression[] { Expression.Constant(searchShort) };
            var expression = GetExpression(dbFieldMember, Int16EqualsMethod, criterionConstant, condition);
            var lambda = Expression.Lambda(expression, dbTypeParameter) as Expression<Func<TDbType, bool>>;

            return predicate.And(lambda);
        }

        private Expression<Func<TDbType, bool>> ApplyInt32Criterion<TDbType, TSearchCriteria>(TSearchCriteria searchCriteria, PropertyInfo searchCriterionPropertyInfo, Type dbType, MemberInfo dbFieldMemberInfo, Expression<Func<TDbType, bool>> predicate, string condition = "==")
        {
            var searchInt = searchCriterionPropertyInfo.GetValue(searchCriteria) as int?;
            if (searchInt == null)
                return predicate;

            var dbTypeParameter = Expression.Parameter(dbType, @"x");
            var dbFieldMember = Expression.MakeMemberAccess(dbTypeParameter, dbFieldMemberInfo);
            var criterionConstant = new Expression[] { Expression.Constant(searchInt) };
            var expression = GetExpression(dbFieldMember, Int32EqualsMethod, criterionConstant, condition);
            var lambda = Expression.Lambda(expression, dbTypeParameter) as Expression<Func<TDbType, bool>>;

            return predicate.And(lambda);
        }

        private Expression<Func<TDbType, bool>> ApplyInt64Criterion<TDbType, TSearchCriteria>(TSearchCriteria searchCriteria, PropertyInfo searchCriterionPropertyInfo, Type dbType, MemberInfo dbFieldMemberInfo, Expression<Func<TDbType, bool>> predicate, string condition = "==")
        {
            var searchLong = searchCriterionPropertyInfo.GetValue(searchCriteria) as long?;
            if (searchLong == null)
                return predicate;

            var dbTypeParameter = Expression.Parameter(dbType, @"x");
            var dbFieldMember = Expression.MakeMemberAccess(dbTypeParameter, dbFieldMemberInfo);
            var criterionConstant = new Expression[] { Expression.Constant(searchLong) };
            var expression = GetExpression(dbFieldMember, Int64EqualsMethod, criterionConstant, condition);
            var lambda = Expression.Lambda(expression, dbTypeParameter) as Expression<Func<TDbType, bool>>;

            return predicate.And(lambda);
        }

        private Expression<Func<TDbType, bool>> ApplyUint16Criterion<TDbType, TSearchCriteria>(TSearchCriteria searchCriteria, PropertyInfo searchCriterionPropertyInfo, Type dbType, MemberInfo dbFieldMemberInfo, Expression<Func<TDbType, bool>> predicate, string condition = "==")
        {
            var searchFloat = searchCriterionPropertyInfo.GetValue(searchCriteria) as float?;
            if (searchFloat == null)
                return predicate;

            var dbTypeParameter = Expression.Parameter(dbType, @"x");
            var dbFieldMember = Expression.MakeMemberAccess(dbTypeParameter, dbFieldMemberInfo);
            var criterionConstant = new Expression[] { Expression.Constant(searchFloat) };
            var expression = GetExpression(dbFieldMember, Uint16EqualsMethod, criterionConstant, condition);
            var lambda = Expression.Lambda(expression, dbTypeParameter) as Expression<Func<TDbType, bool>>;

            return predicate.And(lambda);
        }

        private Expression<Func<TDbType, bool>> ApplyUint32Criterion<TDbType, TSearchCriteria>(TSearchCriteria searchCriteria, PropertyInfo searchCriterionPropertyInfo, Type dbType, MemberInfo dbFieldMemberInfo, Expression<Func<TDbType, bool>> predicate, string condition = "==")
        {
            var searchDouble = searchCriterionPropertyInfo.GetValue(searchCriteria) as double?;
            if (searchDouble == null)
                return predicate;

            var dbTypeParameter = Expression.Parameter(dbType, @"x");
            var dbFieldMember = Expression.MakeMemberAccess(dbTypeParameter, dbFieldMemberInfo);
            var criterionConstant = new Expression[] { Expression.Constant(searchDouble) };
            var expression = GetExpression(dbFieldMember, Uint32EqualsMethod, criterionConstant, condition);
            var lambda = Expression.Lambda(expression, dbTypeParameter) as Expression<Func<TDbType, bool>>;

            return predicate.And(lambda);
        }

        private Expression<Func<TDbType, bool>> ApplyUint64Criterion<TDbType, TSearchCriteria>(TSearchCriteria searchCriteria, PropertyInfo searchCriterionPropertyInfo, Type dbType, MemberInfo dbFieldMemberInfo, Expression<Func<TDbType, bool>> predicate, string condition = "==")
        {
            var searchDecimal = searchCriterionPropertyInfo.GetValue(searchCriteria) as decimal?;
            if (searchDecimal == null)
                return predicate;

            var dbTypeParameter = Expression.Parameter(dbType, @"x");
            var dbFieldMember = Expression.MakeMemberAccess(dbTypeParameter, dbFieldMemberInfo);
            var criterionConstant = new Expression[] { Expression.Constant(searchDecimal) };
            var expression = GetExpression(dbFieldMember, Uint64EqualsMethod, criterionConstant, condition);
            var lambda = Expression.Lambda(expression, dbTypeParameter) as Expression<Func<TDbType, bool>>;

            return predicate.And(lambda);
        }

        private Expression<Func<TDbType, bool>> ApplyDateTimeCriterion<TDbType, TSearchCriteria>(TSearchCriteria searchCriteria, PropertyInfo searchCriterionPropertyInfo, Type dbType, MemberInfo dbFieldMemberInfo, Expression<Func<TDbType, bool>> predicate, string condition = "==")
        {
            var searchDateTime = searchCriterionPropertyInfo.GetValue(searchCriteria) as DateTime?;
            if (searchDateTime == null)
                return predicate;

            var dbTypeParameter = Expression.Parameter(dbType, @"x");
            var dbFieldMember = Expression.MakeMemberAccess(dbTypeParameter, dbFieldMemberInfo);
            var criterionConstant = new Expression[] { Expression.Constant(searchDateTime) };
            var expression = GetExpression(dbFieldMember, DateTimeEqualsMethod, criterionConstant, condition);
            var lambda = Expression.Lambda(expression, dbTypeParameter) as Expression<Func<TDbType, bool>>;

            return predicate.And(lambda);
        }

        private static string GetDbFieldName(PropertyInfo propertyInfo)
        {
            var fieldMapAttribute = propertyInfo.GetCustomAttributes(typeof(IFieldMapAttribute), false).FirstOrDefault();
            var dbFieldName = fieldMapAttribute != null ? ((IFieldMapAttribute)fieldMapAttribute).Field : propertyInfo.Name;

            return dbFieldName;
        }

        private static Expression GetExpression(MemberExpression fieldMember, MethodInfo methodInfo, Expression[] criterionConstant, string condition)
        {
            switch (condition)
            {
                case ">":
                    return Expression.GreaterThan(fieldMember, criterionConstant[0]);
                case ">=":
                    return Expression.GreaterThanOrEqual(fieldMember, criterionConstant[0]);
                case "<":
                    return Expression.LessThan(fieldMember, criterionConstant[0]);
                case "<=":
                    return Expression.LessThanOrEqual(fieldMember, criterionConstant[0]);
                default:
                    return Expression.Call(fieldMember, methodInfo, criterionConstant);
            }
        }
    }
}
