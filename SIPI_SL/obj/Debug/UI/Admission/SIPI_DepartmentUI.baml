   M S B A M L   `   `   `  ����  SIPI_SL,    &SIPI_SL.UI.Admission.SIPI_DepartmentUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Department UI��5   	   $��456.865��6   $��726.867��60      	GrayWhite#��[  6@    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��	0,6,-8,-5q�6   .+�5   
   �� $��-3,0,33,280q�6   .��5      � $��0,0,-2,4q�6   .+�5	      �� -   5        $��sipi_ProgramCombobax��5	   n   $
��Left=�6   $��
155,14,0,0q�66   $	��Top=�6J   $	��161��6b     ComboBoxBGYellowGreen#��[ 5
      ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $	��120��6N   ��6,   �� *SIPI_ProgramName+6N   �� 5   "   $��||��6,   �� 5   "   $��60��6N   ��6,   �� *SIPI_ProgramTime+6N   5      5      5      �� 5      $��Program Name��6   $
��Left=�6/   $��	27,14,0,0q�6J   $	��Top=�6]   �� 5      $��Technology ��6   $
��Left=�6.   $��	27,48,0,0q�6I   $	��Top=�6\   �� 5      $,��&Regulation / প্রবিধান ��6   $
��Left=�69   $��
321,14,0,0q�6T   $	��Top=�6h   �� 5      $��
Entry Date��6   $
��Left=�6-   $��
321,38,0,0q�6H   $	��Top=�6\   �� 5      -   5         ��Name$ departmentNameTextBox��5   �   $
��Left=�6   $��23��65   $��
155,50,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��161��6�   6�   �� 5      $��Technology Code��6   $
��Left=�62   $��	27,73,0,0q�6M   $	��Top=�6`   �� 5      -   5        $ departmentCodeTextBox��5   �   $
��Left=�6   $��23��65   $��
155,75,0,0q�6A   $
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��161��6�   6�   �� 5       $��Technology In Bangla��6   $
��Left=�67   $��
27,100,0,0q�6R   $	��Top=�6f   �� 5!      -   5        $ bangladepartmentTextBox��5!   �   $
��Left=�6   $��23��65   $��155,102,0,0q�6A   $
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $	��161��6�   6�   �� 5"      -   5        $ regulationTextBox��5"   �   $
��Left=�6   $��23��65   $��
467,17,0,0q�6A   $
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��120��6�   6�   (  "System.Windows.Controls.DatePicker  5#      -   5        $#��regulationEntryDateDatePicker��5#   �   
�������$
��Left=�60   $��
467,45,0,0q�6K   $	��Top=�6_   $	��120��6w   $��24��6�   6�   �� 5%      -   5        $��
saveButton��5%   {   $
��Save��6   $
��Left=�6(   $��602,102,0,0q�6C   $	��Top=�6X   $��75��6p   $��23��6�   6�   �� 5'      -   5        $��clearButton��5'   |   $��Clear��6   $
��Left=�6)   $��512,102,0,0q�6D   $	��Top=�6Y   $��75��6q    J� RenderTransformOrigin$ 0.284,0.634&�6�   $��23��6�   6�   5*      5+      �� 5-   
   $��Department Info��6   $��
51,177,0,0q�6,   $	��Top=�6@   $	��188��6X   $
��Left=�6e   $	��643��6�   .��5.      � $	��117��6   $	��Top=�6    $��	10,48,0,0q�68   $
��Left=�6K   $	��621��6f   .+�51      �� -	   5        $��sIPIDepartmentListView��54      $	��156��51      $
��Left=�52      $��
10,-39,0,0q�53      $	��Top=�55      $	��600��56         alternatingListViewItemStyle#��[ 57       �� AlternationCount$ 2��58       � ContextMenu 59      �� 5:      -
   5        $��
proramList��5:   &   	 �� 	StaysOpen	 . 
�������
 J� BitmapEffect
 5;      �� 5<   "   .@�5>      m� -   5        $#��EditSIPI_DeprtmentContextMenu��5>   5   $
��Edit��6'   6Z   m� 5?      -   5        $%��RemoveSIPI_DeprtmentContextMenu��5?   7   $��Remove��6'   6^   m� 5@      -   5        $��ViewContextMenu��5@   5   $
��View��6'   6L   5A       �� View 5C      �� 5D       �� AllowsColumnReorder . .P�5E      �� $�� ��6V    �� Width$ 0��6`    �� DisplayMemberBinding 6-   ��  �� Path$ Id�6`   �� 5F      $��Program Name��6d   $	 200��6z    6-   �� $ SIPI_ProgramName�6z   �� 5G      $��Department Name��6g   $	 200��6�    6-   �� $ SIPI_DepartmentName�6�   �� 5H      $��Department Code��6g   $	 200��6�    6-   �� $ SIPI_DepartmentCode�6�   �� 5I      $��
Regulation��6^   $	 100��6r    6-   �� $ 
Regulation�6r   5K      5M      5N      5O      5R      5S      