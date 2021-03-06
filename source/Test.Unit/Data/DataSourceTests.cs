﻿using NUnit.Framework;
using Moq;
using Shuttle.Core.Data;

namespace Test.All
{
	[TestFixture]
	public class DataSourceTests
	{
		[Test]
		public void Should_be_able_to_create_a_data_source()
		{
			var factory = new Mock<IDbDataParameterFactory>();

			var ds = new DataSource("DATA-SOURCE", factory.Object);

			Assert.AreEqual("DATA-SOURCE", ds.Name);
			Assert.AreEqual("data-source", ds.Key);
			Assert.AreSame(factory.Object, ds.DbDataParameterFactory);
		}
	}
}