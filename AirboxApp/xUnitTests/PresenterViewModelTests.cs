using AirboxApp.Enums;
using AirboxApp.ViewModels;
using Moq;
using Xunit;
using FluentAssertions;
using System.Collections.ObjectModel;
using AirboxApp.Manager;
using AirboxApp.Models;

namespace AirboxApp.Tests
{
    public class PresenterViewModelTests
    {
        #region Properties
        private readonly PresenterViewModel _viewModel;
        #endregion

        #region Constructor
        public PresenterViewModelTests()
        {
            // Initialize the PresenterViewModel
            _viewModel = new PresenterViewModel();
        }
        #endregion

        #region Tests
        [Fact]
        public void Constructor_ShouldInitializeImageSets()
        {
            // Assert that image sets are populated
            _viewModel.Cars.Should().NotBeNullOrEmpty();
            _viewModel.Boats.Should().NotBeNullOrEmpty();
            _viewModel.Helicopters.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void ChangeImageSet_ShouldSelectCarSet_WhenCarTypeIsSelected()
        {
            // Act
            _viewModel.ChangeImageSet.Execute(ImageSetType.CarType);

            // Assert
            _viewModel.SelectedSet.Should().BeEquivalentTo(_viewModel.Cars);
        }

        [Fact]
        public void ChangeImageSet_ShouldSelectBoatSet_WhenBoatTypeIsSelected()
        {
            // Act
            _viewModel.ChangeImageSet.Execute(ImageSetType.BoatType);

            // Assert
            _viewModel.SelectedSet.Should().BeEquivalentTo(_viewModel.Boats);
        }

        [Fact]
        public void ChangeImageSet_ShouldSelectHelicopterSet_WhenHelicopterTypeIsSelected()
        {
            // Act
            _viewModel.ChangeImageSet.Execute(ImageSetType.HelicopterType);

            // Assert
            _viewModel.SelectedSet.Should().BeEquivalentTo(_viewModel.Helicopters);
        }

        [Fact]
        public void ChangeImageSet_ShouldThrowNotImplementedException_WhenUnknownTypeIsSelected()
        {
            // Act
            var exception = Record.Exception(() => _viewModel.ChangeImageSet.Execute((ImageSetType)999));

            // Assert
            exception.Should().BeOfType<NotImplementedException>();
        }
        #endregion
    }
}