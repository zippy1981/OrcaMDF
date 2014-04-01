using System;

namespace OrcaMDF.Core.MetaData.BaseTables
{
    internal class sysdbreg : Row
    {
        private static readonly ISchema schema = new Schema(new[]
        {
            new DataColumn("id", "int"),
            new DataColumn("name", "sysname"),
            new DataColumn("sid", "varbinary", true),
            new DataColumn("status", "int"),
            new DataColumn("status2", "int"),
            new DataColumn("category", "int"),
            new DataColumn("crdate", "datetime"),
            new DataColumn("modified", "datetime"),
            new DataColumn("svcbrkrguid", "uniqueidentifier"),
            new DataColumn("scope", "int"),
            new DataColumn("cmptlevel", "tinyint")
        });

        public sysdbreg()
            : base(schema)
        { }

        public override Row NewRow()
        {
            return new sysdbreg();
        }

        internal int id { get { return Field<int>("id"); } }
        internal string name { get { return Field<string>("name"); } }
        internal int sid { get { return Field<int>("sid"); } }
        internal int status { get { return Field<int>("status"); } }
        internal int status2 { get { return Field<int>("status2"); } }
        internal int category { get { return Field<int>("category"); } }
        internal DateTime crdate { get { return Field<DateTime>("crdate"); } }
        internal DateTime modified { get { return Field<DateTime>("modified"); } }
        internal Guid svcbrkrguid { get { return Field<Guid>("svcbrkrguid"); } }
        internal int scope { get { return Field<int>("scope"); } }
        internal byte cmptlevel { get { return Field<byte>("cmptlevel"); } }
    }
}