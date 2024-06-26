﻿// <copyright file="TestReviewRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace UBB_Business_Ads.Tests.RepoTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using Backend.Models;
    using Backend.Repositories;
    using Moq;
    using Xunit;

    public class TestReviewRepository
    {
        private ReviewRepository repository;

        public TestReviewRepository()
        {
            this.repository = new ReviewRepository();
        }

        [Fact]
        public void AddReview_WhenReviewElementIsAdded_ShouldAddElement()
        {
            var repo = new Mock<ReviewRepository>();
            var reviewElement = new ReviewClass("user1", "review1");
            this.repository.AddReview(reviewElement);
            Xunit.Assert.Contains(reviewElement, this.repository.GetReviewList());
        }

        [Fact]
        public void GetReviewList_WhenFetchingReviews_ShouldReturnReviewsListSameNumberOfElements()
        {
            var result = this.repository.GetReviewList();
            Xunit.Assert.NotNull(result);
            Xunit.Assert.Equal(expected: this.repository.GetReviewList().Count, result.Count());
        }
    }
}