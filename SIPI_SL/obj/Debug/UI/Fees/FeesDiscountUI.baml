   M S B A M L   `   `   `  ����  SIPI_SL$    SIPI_SL.UI.Fees.FeesDiscountUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Fees Discount UI��5   	   $��525.657��6"   $��814.638��63    � ShowInTaskbar .     	GrayWhite#��[  6Y    � WindowStartupLocation$ CenterScreen=�6�   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��308* �6   �� 5      $
��485* �6   .+�5
   
   �� $��Student Info��6   $
��Left=�6)   $��	10,21,0,0q�6D   $	��Top=�6W   $��77��6o   $	��773��6{   $
��Bold"�6�   $��2��6�   .��5      � .+�5      �� $
��Name��6   $
��Left=�6'   $��10,0,0,0q�6B   $	��Top=�6T   $	��106��6l   �� 5      -   5        $��nameTextBox��5   �   $
��Left=�6   $��23��65   $��75,0,0,0q�6A    �� TextWrapping$
 Wrap=�6S   $	��Top=�6i   $	��247��6�   6�   �� 5      $��
Department��6   $
��Left=�6-   $��
342,-3,0,0q�6H   $	��Top=�6\   $	��106��6t   �� 5      -   5        $��DepartmentTextBox��5   �   $
��Left=�6   $��23��65   $��	425,0,0,0q�6A   $
 Wrap=�6T   $	��Top=�6j   $	��326��6�   6�   �� 5      $��Id��6   $
��Left=�6%   $��	10,30,0,0q�6@   $	��Top=�6S   $��82��6k   $��24��6v   �� 5      -   5        $��	idTextBox��5   �   $
��Left=�6   $��23��65   $��	75,31,0,0q�6A   $
 Wrap=�6T   $	��Top=�6h   $	��247��6�   6�   �� 5      -   5        $��getStudentPopupButton��5   �   $��Get Student��6   $
��Left=�6/   $��
425,28,0,0q�6J   $	��Top=�6^   $��83��6v   $��24��6�   6�   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��setupFeesDataGrid��5   k      AutoGenerateColumns .  $	��202��6/   $
��Left=�6<   $��
25,143,0,0q�6W   $	��Top=�6�   $	��744��6�      CanUserAddRows .  $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly . 	   Header$	 Fees Details Name��67   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 450 6t   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   ��  �� Path$ FeesName�6t   4  .System.Windows.Controls.DataGridTemplateColumn  5!       . $	 Fees Amount��6;   $	
 250 6P      CellTemplate 5"      �� 5#      .R�5$      �� $	��txt��6B   ��6&   �� *
FeesAmount+6B   5%      5'      5*      �� 5+   
   $
��Left=�6   $��23��6-   $��175.071,350,0,0q�69   $
 Wrap=�6R   $	��Top=�6h   $	��260��6�   $��1��6�   �� 5,   
   $
��Left=�6   $��23��6-   $��175.071,376,0,0q�69   $
 Wrap=�6R   $	��Top=�6f   $	��260��6~   $��1��6�   �� 5-   
   $
��Left=�6   $��23��6-   $��175.071,404,0,0q�69   $
 Wrap=�6R   $	��Top=�6f   $	��260��6~   $��1��6�   �� 5.   
   $��Total��6   $
��Left=�6    $��123.071,350,0,0q�6;   $	��Top=�6T   $
��Bold"�6l   $��1��6~   �� 5/   
   $��Discount��6   $
��Left=�6#   $��101.071,373,0,0q�6>   $	��Top=�6W   $
��Bold"�6o    J� RenderTransformOrigin$ 2.656,0.526&�6�   $��1��6�   �� 50   
   $��Payable Amount��6   $
��Left=�6)   $��58.071,401,0,0q�6D   $	��Top=�6\   $
��Bold"�6t   $��1��6�   �� 52   
   -   5         ��Name$ semesterCombobax��53      $
��Left=�52      $��106,104,0,0q�6.   $	��Top=�6D   $	��155��6\     ComboBoxBGYellowGreen#��[ 54      ��55      �� 56      .R�57      ��  �� Orientation$ 
Horizontal=�6!   .+�58      �� $��60��6@   ��6$   �� *
SemesterNo+6@   5;      5<      5>      �� 5?   
   $��Semester��6   $
��Left=�6#   $��
25,107,0,0q�6>   $	��Top=�6R   $��62��6j   $
��Bold"�6v   �� 5A   
   -   5        $��yearCombobox��5A   f   $
��Left=�6   $��
30,103,0,0q�6.   $	��Top=�6B   $	��120��6Z   #��[ 5B   	   $��1��68   �� 5C   
   $
��Year��6   $
��Left=�6   $��281,107,0,0q�6:   $	��Top=�6O   $��62��6g   $
��Bold"�6r   $��2��6�   5E      5F      