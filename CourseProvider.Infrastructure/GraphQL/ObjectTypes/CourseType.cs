using CourseProvider.Infrastructure.Data.Entities;
using HotChocolate.Types;

namespace CourseProvider.Infrastructure.GraphQL.ObjectTypes
{
    public class CourseType : ObjectType<CourseEntity>
    {
        protected override void Configure(IObjectTypeDescriptor<CourseEntity> descriptor)
        {
            descriptor.Field(c => c.Id).Type<NonNullType<IdType>>();
            descriptor.Field(c => c.ImageUri).Type<StringType>();
            descriptor.Field(c => c.ImageHeaderUri).Type<StringType>();
            descriptor.Field(c => c.IsBestSeller).Type<NonNullType<BooleanType>>();
            descriptor.Field(c => c.IsDigital).Type<NonNullType<BooleanType>>();
            descriptor.Field(c => c.Categories).Type<NonNullType<ListType<NonNullType<StringType>>>>();
            descriptor.Field(c => c.Title).Type<NonNullType<StringType>>();
            descriptor.Field(c => c.Ingress).Type<StringType>();
            descriptor.Field(c => c.StarRating).Type<NonNullType<DecimalType>>();
            descriptor.Field(c => c.Reviews).Type<StringType>();
            descriptor.Field(c => c.LikesInProcent).Type<StringType>();
            descriptor.Field(c => c.Likes).Type<StringType>();
            descriptor.Field(c => c.Hours).Type<StringType>();
            descriptor.Field(c => c.Authors).Type<NonNullType<ListType<NonNullType<AuthorType>>>>();
            descriptor.Field(c => c.Prices).Type<PricesType>();
            descriptor.Field(c => c.Content).Type<ContentType>();
        }
    }

    public class AuthorType : ObjectType<AuthorEntity>
    {
        protected override void Configure(IObjectTypeDescriptor<AuthorEntity> descriptor)
        {
            descriptor.Field(a => a.Name).Type<NonNullType<StringType>>();
        }
    }

    public class ContentType : ObjectType<ContentEntity>
    {
        protected override void Configure(IObjectTypeDescriptor<ContentEntity> descriptor)
        {
            descriptor.Field(c => c.Description).Type<StringType>();
            descriptor.Field(c => c.Includes).Type<NonNullType<ListType<NonNullType<StringType>>>>();
            descriptor.Field(c => c.ProgramDetails).Type<ListType<NonNullType<ProgramDetailItemType>>>();
        }
    }

    public class PricesType : ObjectType<PricesEntity>
    {
        protected override void Configure(IObjectTypeDescriptor<PricesEntity> descriptor)
        {
            descriptor.Field(p => p.Currency).Type<NonNullType<StringType>>();
            descriptor.Field(p => p.Price).Type<NonNullType<DecimalType>>();
            descriptor.Field(p => p.Discount).Type<NonNullType<DecimalType>>();
        }
    }

    public class ProgramDetailItemType : ObjectType<ProgramDetailItemEntity>
    {
        protected override void Configure(IObjectTypeDescriptor<ProgramDetailItemEntity> descriptor)
        {
            descriptor.Field(pd => pd.Id).Type<NonNullType<IntType>>();
            descriptor.Field(pd => pd.Title).Type<StringType>();
            descriptor.Field(pd => pd.Description).Type<StringType>();
        }
    }
}
