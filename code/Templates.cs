namespace Sitecore.Foundation.Models
{
    using Sitecore.Data;

    public struct Templates
    {
        public struct File
        {
            public const string ID_String = "{962B53C4-F93B-4DF9-9821-415C867B8903}";
            public static ID ID = new ID(ID_String);

            public struct Fields
            {
                public const string Title_String = "{3F4B20E9-36E6-4D45-A423-C86567373F82}";
                public const string Keywords_String = "{2FAFE7CB-2691-4800-8848-255EFA1D31AA}";
                public const string Description_String = "{BA8341A1-FF30-47B8-AE6A-F4947E4113F0}";
                public const string Extension_String = "{C06867FE-9A43-4C7D-B739-48780492D06F}";
                public const string MimeType_String = "{6F47A0A5-9C94-4B48-ABEB-42D38DEF6054}";
                public const string Size_String = "{6954B7C7-2487-423F-8600-436CB3B6DC0E}";

                public static readonly ID Title = new ID(Title_String);
                public static readonly ID Keywords = new ID(Keywords_String);
                public static readonly ID Description = new ID(Description_String);
                public static readonly ID Extension = new ID(Extension_String);
                public static readonly ID MimeType = new ID(MimeType_String);
                public static readonly ID Size = new ID(Size_String);
            }
        }

        public struct BaseItem
        {
            public struct Fields
            {
                public const string SortOrder_String = "{BA3F86A2-4A1C-4D78-B63D-91C2779C1B5E}";
                public const string Created_String = "{25BED78C-4957-4165-998A-CA1B52F67497}";
                public const string Updated_String = "{D9CF14B1-FA16-4BA6-9288-E8A174D4D522}";
                public const string Workflow_String = "{A4F985D9-98B3-4B52-AAAF-4344F6E747C6}";
                public const string WorkflowState_String = "{3E431DE1-525E-47A3-B6B0-1CCBEC3A8C98}";

                public static readonly ID SortOrder = new ID(SortOrder_String);
                public static readonly ID Created = new ID(Created_String);
                public static readonly ID Updated = new ID(Updated_String);
                public static readonly ID Workflow = new ID(Workflow_String);
                public static readonly ID WorkflowSate = new ID(WorkflowState_String);
            }
        }
    }
}
