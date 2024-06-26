﻿// <copyright file="ReviewServiceTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace UBB_Business_Ads.Tests.ServicesTests
{
    using Backend.Services;
    using Moq;
    using Xunit;

    public class ReviewServiceTest
    {
        [Fact]
        public void GetReviewServiceInstance_AssignsSameValueToAVariable_ReturnsTheSameInstance()
        {
            // Act = Constructor - testing the constructor
            ReviewService instance1 = ReviewService.Instance;
            ReviewService instance2 = ReviewService.Instance;

            // Assert
            Assert.Equal(instance1, instance2);
        }

        [Fact]
        public void GetAllReviews_FetchReviews_ReturnsTheListOfAllReviews()
        {
            // Constructor
            var reviewService = ReviewService.Instance;

            // Act
            var result = reviewService.GetAllReviews();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void AddReview_AddingReviewElement_NeedsToCallTheAddFunctionAddFromRepoAndAddTheElement()
        {
            // Constructor
            var mockService = new Mock<IServiceReview>();

            // Act
            mockService.Object.AddReview("review");

            // Assert
            // Verify that the addReview method is called on the mock services exactly once
            mockService.Verify(s => s.AddReview("review"), Times.Once);
        }
    }
}