   M S B A M L   `   `   `  ����  SIPI_SL7    1SIPI_SL.UI.InventoryManagement.ProductMasterEntry   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Product Master Entry��5   	   $��402.724��6&   $��616.343��67    � WindowStartupLocation$ CenterScreen=�6G      	GrayWhite#��[  6l    � ShowInTaskbar .  .��5      � .+�5   
   �� $��Product Name��6   $
��Left=�6'   $��	29,11,0,0q�6B   $	��Top=�6U   $	��102��6m   �� 5   
   -   5        $��ProductNameTextBox��5   �   $
��Left=�6   $��30��6-   $��
149,10,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6c   $	��222��6{   6�   �� 5   
   -   5        $��UnitTypeNoteTextbox��5   �   $
��Left=�6   $	��106��6-   $��
376,42,0,0q�6:   $
 Wrap=�6N    �� AcceptsReturn . " �� VerticalScrollBarVisibility$ Visible=�6w   $	��Top=�6�   $	��222��6�   6�   �� 5	   
   $��Brand��6   $
��Left=�6    $��	29,45,0,0q�6;   $	��Top=�6N   $	��102��6f   �� 5
   
   -   5        $��brandNameCombobox��5
   f   $
��Left=�6   $��
149,42,0,0q�6.   $	��Top=�6B   $	��222��6Z     ComboBoxBGYellowGreen#��[ 6   �� 5   
   -   5         ��Name$ 
saveButton��5   �   $
��Bold"�6   $��6q�6#   $
��SAVE��67   $
��Left=�6F   $��518,153,0,0q�6a   $	��Top=�6v   $��78��6�   6�   �� 5   
   -   5        $ clearButton��5   �   $
��Bold"�6   $��6q�6#   $��Clear��67   $
��Left=�6G   $��440,153,0,0q�6b   $	��Top=�6w   $��78��6�   6�   �� 5   
   -   5        $ ��productMasterEntryListview��5   s   $
��Left=�6   $	��173��6.   $��
10,188,0,0q�6;   $	��Top=�6O   $	��588��6g    �� View 5      �� 5      .P�5      �� $��ID��6O    �� Width$ 0��6[   	 �� DisplayMemberBinding	 6%   �� 
 �� Path$
 Id�6[   �� 5      $��Product Name��6Y   $
 Auto��6o   	 6%   �� $
 Product_Name�6o   �� 5      $��
Brand Name��6V   $
 Auto��6j   	 6%   �� $
 	BrabdName�6j   �� 5      $��Category Name��6Y   $
 Auto��6p   	 6%   �� $
 CategoryName�6p   �� 5      $��CategoryName��6X   $
 Auto��6n   	 6%   �� $
 CategoryName�6n   �� 5      $��	Unit Type��6X   $
 Auto��6k   	 6%   �� $
 UnitTypeName�6k   �� 5      $��Stock In Hand��6X   $
 Auto��6o   	 6%   �� $
 Stock_InHand�6o   5      5      �� 5   
   $��Category Name��6   $
��Left=�6(   $��	29,82,0,0q�6C   $	��Top=�6V   $	��102��6n   �� 5   
   -   5         ��Name$ CategoryNameCombobox��5   f   $
��Left=�6   $��
149,78,0,0q�6.   $	��Top=�6B   $	��222��6Z   #��[ 6�   �� 5   
   $��	Unit Type��6   $
��Left=�6$   $��
29,116,0,0q�6?   $	��Top=�6S   $	��102��6k   �� 5   
   -   5        $ UnitTypeNameCombobox��5   g   $
��Left=�6   $��149,114,0,0q�6.   $	��Top=�6C   $	��222��6[   #��[ 6�   �� 5    
   $��Unit Type Note��6   $
��Left=�6)   $��
378,14,0,0q�6D   $	��Top=�6X   $��91��6p   �� 5!   
   $�� ��6   $
��Left=�6   $��
581,23,0,0q�69   $	��Top=�6M   $��14��6e   $��17��6q   5"      5#      