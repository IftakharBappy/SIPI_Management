   M S B A M L   `   `   `  ����  SIPI_SL8    2SIPI_SL.UI.ScholarshipManagement.OldScholarsListUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   a
extToolkitJhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit/extended     5   	     � Title$  Student List UI��5   	   $��568.693��6!   $��1008.893��62    � ShowInTaskbar .     	GrayWhite#��[  6Y    � WindowStartupLocation$ CenterScreen=�6�   .��5      � $	��367��6   $��Bottom=�6   $��0,0,-8,0q�63    � ColumnDefinitions 5   
   �� 5	      $
��308* �6   �� 5
      $
��424* �6   �� 5      $
��277* �6   .+�5   
   � $��3��6    5      �� 5      $
��293* �6#   �� 5      $
��716* �6#   .+�5      �� -   5        $��SearchButton��5   �   $��Search��6   $
��Left=�6&   $��537,-142,0,0q�6A   $	��Top=�6W   $��86��6o   $��32��6z    J� RenderTransformOrigin$ 3.221,-0.219&�6�   $��1��6�   5      � 5   
   $��
0,10,27,10q�6   $��Right=�6#   $	��763��6?   $��3��6K   .+�5      �� -   5        $��studentInofListView��5      $��-190,-104,0,0q�63   $	��441��6J   $	��Top=�6W   $��Right=�5      $	��953��6-      alternatingListViewItemStyle#��[ 5       �� AlternationCount$ 2��6U    �� View 5      �� 5       �� AllowsColumnReorder . .P�5      �� $	��S.L��6R    �� Width$ 30��6_   	 �� DisplayMemberBinding	 6)   �� 
 �� Path$
 Id�6_   �� 5       $��
Student Id��6Y   $	 100��6m   	 6)   �� $
 	StudentID�6m   �� 5!      $��Student Name��6]   $	 350��6s   	 6)   �� $
 ApplicantName�6s   �� 5"      $��Student Mobile��6^   $	 200��6v   	 6)   �� $
 DepartmentName�6v   �� 5#      $��Campus��6Z   $	 230��6j   	 6)   �� $
 
CampusName�6j   5'      5)      5*      5-      5.      