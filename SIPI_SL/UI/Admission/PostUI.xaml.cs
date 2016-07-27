using BLL.Admission;
using ENTITY.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace SIPI_SL.UI.Admission
{
    /// <summary>
    /// Interaction logic for PostUI.xaml
    /// </summary>
    public partial class PostUI : Window
    {
        ThanaManager ThanaManagerObj = new ThanaManager();
        DistrictManager districtManagerObj = new DistrictManager();
        PostManager postManagerObj = new PostManager();
        District _districtObj;
        Post _postObj;
        Thana _ThanaObj;
        List<Post> PostList;
        List<Thana> ThanaList;
        List<District> DistrictList;

        
        public PostUI()
        {
            InitializeComponent();
            LoadThanaComboBox(-1);
            LoadDistrictComboBox();
            LoadAllPost();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {

            if (submitButton.Content.ToString() == "Save")
            {
                _postObj = new Post();

                ///Combobox
                
                _districtObj = new District();
                _districtObj = ((District)districtCombobax.SelectedItem);
                _postObj.DistrictId = _districtObj.Id; /// save DistrictId in Post Table
            
                
                ///
                ///Combobox

                _ThanaObj = new Thana();
                _ThanaObj = ((Thana)thanaCombobax.SelectedItem);
                _postObj.ThanaId = _ThanaObj.Id; /// save ThanaId in Post Table

                ///

                _postObj.PostName = postNameTextBox.Text ;
                _postObj.PostCode = postCodeTextBox.Text;
                _postObj.BanglaPostName = banglaPostNameTextBox.Text;
         
                                              
                postManagerObj.SavePost(_postObj);
                LoadAllPost();
                MessageBox.Show("Data insurted successfully");

               
            }

            if (submitButton.Content.ToString() == "Update")
            {
                _districtObj = new District();
                _districtObj = ((District)districtCombobax.SelectedItem);
                _postObj.DistrictId = _districtObj.Id;

                _ThanaObj = new Thana();
                _ThanaObj = ((Thana)thanaCombobax.SelectedItem);
                _postObj.ThanaId = _ThanaObj.Id;

                _postObj.PostName = postNameTextBox.Text;
                _postObj.PostCode = postCodeTextBox.Text;
                _postObj.BanglaPostName = banglaPostNameTextBox.Text;

                postManagerObj.UpdatePost(_postObj);
                LoadAllPost();    

                submitButton.Content = "Save";
                MessageBox.Show("Data Update successfully");
            }
          
        }
        private void LoadDistrictComboBox()
        {
            DistrictList = new List<District>();
            districtCombobax.Items.Clear();
            DistrictList = districtManagerObj.GetAllDistrict();
            foreach (District didtrict in DistrictList)
            {
                districtCombobax.ItemsSource = DistrictList;
            }
        }

         

        private void LoadAllPost()
        {
            PostList = new List<Post>();
            PostList = postManagerObj.GetAllPost();
            postlistView.Items.Clear();
             if (PostList.Count > 0)
            {
                foreach (var item in PostList)
                {
                    postlistView.Items.Add(item);
                }

            }
        }

        private void RemoveThanaContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _postObj = new Post();
            _postObj = ((Post)postlistView.SelectedItem);
            postManagerObj.DeletePost(_postObj);
            LoadAllPost();
            MessageBox.Show("Selected Item Removed");

        }

        private void EditThanaContextMenu_Click_1(object sender, RoutedEventArgs e)
        {
            _postObj = new  Post();
            _postObj = ((Post)postlistView.SelectedItem);
            ////FOR DISTRICT COMBOBOX
            for (int i = 0; i < districtCombobax.Items.Count; i++)
            {
                District dis = (District)districtCombobax.Items[i];
                if (_postObj.DistrictId == dis.Id)
                {
                    districtCombobax.SelectedIndex = i;
                    break;
                    
                }
                
            }
            ////FOR THANA COMBOBOX
            for (int i = 0; i < thanaCombobax.Items.Count; i++)
            {
                Thana dis = (Thana)thanaCombobax.Items[i];
                if (_postObj.ThanaId == dis.Id)
                {
                    thanaCombobax.SelectedIndex = i;
                    break;

                }

            }


            postNameTextBox.Text = _postObj.PostName;
            postCodeTextBox.Text = _postObj.PostCode;
            banglaPostNameTextBox.Text = _postObj.BanglaPostName;
              
            submitButton.Content = "Update";
        }

        private void districtCombobax_DropDownClosed(object sender, EventArgs e)
        {
            LoadThanaComboBox(0);
        }

        private void LoadThanaComboBox(int p)
        {
            if (p == -1)
            {
                ThanaList = ThanaManagerObj.LoadAllThana(p);
                foreach (Thana thana in ThanaList)
                {
                    thanaCombobax.ItemsSource = ThanaList;
                }
            }

            else
            {
                try
                {
                    District district = districtCombobax.SelectedItem as District;
                    ThanaList = ThanaManagerObj.LoadAllThana(district.Id);

                    foreach (Thana thana in ThanaList)
                    {
                        thanaCombobax.ItemsSource = ThanaList;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Product Category", "Confirmation");
                }


            }
        }

      
         


       
    }
}
