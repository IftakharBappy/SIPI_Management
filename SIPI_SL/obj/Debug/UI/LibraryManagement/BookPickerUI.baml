   M S B A M L   `   `   `  ����  SIPI_SL/    )SIPI_SL.UI.LibraryManagement.BookPickerUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Book Picker UI��5   	   $	��357��6    $	��584��6-      	GrayWhite#��[  69    � WindowStartupLocation$ CenterScreen=�6a   .��5      � .+�5   
   � $��Right=�6   $	��566��6,   .+�5      �� -   5        $��bookListView��5      $	��246��6-   $	��Top=�6:      alternatingListViewItemStyle#��[ 5   B    �� AlternationCount$ 2��6�   $��
10,70,10,0q�6�    �� View 5
      �� 5       �� AllowsColumnReorder . .P�5      �� $	��S.L��6R    �� Width$
 Auto��6_    �� DisplayMemberBinding 6)   ��  �� Path$ Id�6_   �� 5      $��	Book Name��6X   $
 Auto��6k    6)   �� $ BookName�6k   �� 5      $��Book Author��6Z   $
 Auto��6o    6)   �� $ 
BookAuthor�6o   �� 5      $��
Department��6^   $
 Auto��6r    6)   �� $ DepartmentName�6r   �� 5      $��Book Quantity��6X   $
 Auto��6o    6)   �� $ Quantity�6o   5      5      5      5      5      