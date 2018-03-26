using System;
using Xunit;

namespace CSI6111.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Should_Authenicate_User()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Should_Reject_Unauthenicated_User()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Should_Allow_Client_StudentIDEntry()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Should_Allow_Client_Mark_Individual_UnitEntry()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Should_Display_Result_Evaluation()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Should_Allow_Between_12_And_30_Marks()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Should_Automatically_Disqualified_If_Failed_MoreThan6Units()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Should_Display_Individual()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Should_Select_Best_8_Marks()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Should_Calculate_Average_8_Marks()
        {
            throw new NotImplementedException();
        }


        [Fact]
        public void Should_Calculate_Cource_Average()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Should_Evaluate_Qualification()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Should_Return_Valid_Evaluation()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Should_Return_Message_If_Average_EqualOrGreaterThen70()
        {
            Assert.Equal("", "student ID, course average, QUALIFIED FOR HONOURS STUDY!");
        }

        [Fact]
        public void Should_Return_Message_If_AverageLessThen70_But_AverageOfBest8Is80OrHigher()
        {
            Assert.Equal("", $"<student ID>, <course average>,< best 8 average >, MAY HAVE GOOD CHANCE!Need further assessment!");
        }

        [Fact]
        public void Should_Return_Message_If_AverageLessThen70_But_AverageOfBest8IsBetween70And79()
        {
            Assert.Equal("", $"<student ID>, <course average >, < best 8 average >, MAY HAVE A CHANCE!Must be carefully reassessed and get the coordinator’s special permission!");
        }

        [Fact]
        public void Should_Return_Message_If_AverageLessThen70_But_AverageOfBest8IsLessthan70()
        {
            Assert.Equal("", $"<student ID>, <course average>, < best 8 average >, DOES NOT QUALIFY FOR HONORS STUDY!Try Masters by course work.");
        }
    }
}
