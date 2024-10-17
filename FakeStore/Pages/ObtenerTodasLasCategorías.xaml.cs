using FakeStore.Dtos;
using FakeStore.Services;
using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace FakeStore.Pages
{
    public partial class GetAllCategoriesPage : ContentPage
    {
        private readonly ObtenerTodasLasCategor�asServicio _getAllCategoriesService = new ObtenerTodasLasCategor�asServicio();

        public GetAllCategoriesPage()
        {
            InitializeComponent();
            LoadCategoriesAsync();
        }

        private async void LoadCategoriesAsync()
        {
            try
            {
                var categories = await _getAllCategoriesService.GetAllCategoriesAsync();
                CategoryPicker.ItemsSource = categories; 
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Ocurri� un error al cargar las categor�as: {ex.Message}", "OK");
            }
        }

        private async void OnGetProductsClicked(object sender, EventArgs e)
        {
            var selectedCategory = CategoryPicker.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCategory))
            {
                await DisplayAlert("Error", "Por favor, selecciona una categor�a.", "OK");
                return;
            }

            try
            {
                var products = await _getAllCategoriesService.GetProductsByCategoryAsync(selectedCategory);
                ProductsCollectionView.ItemsSource = products;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Ocurri� un error al obtener los productos: {ex.Message}", "OK");
            }
        }

        private void OnCategorySelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = CategoryPicker.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                
            }
        }
    }
}
