   M S B A M L   `   `   `  ����  SIPI_SL5    /SIPI_SL.UI.SMSManagement.SMSManagementDeshboard   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$!  SMS Management Deshboard UI��5   	   $��474.466��6-    � WindowState$ 	Maximized=�6>    � WindowStartupLocation$ CenterScreen=�6V      	GrayWhite#��[  6{    � ShowInTaskbar .  $��774.104��6�   .��5      � .+�5   
   �� $	��SMS��6   $��Center=�6!   $��
33,10,25,0q�6>   $	��Top=�6R   $	��708��6j   $	��387��6v   .��5	      � .+�5
      �� -   5        $��departmentCombobox��5       J� RenderTransformOrigin$ 0.037,0.146&�5      $��96,8,0,0q�5   +   $
��Left=�6=   $	��219��6X   $��33��6d   $	��Top=�6p   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $	��130��6Q   ��6,   �� *SIPI_DepartmentName+6Q   5      5      5      �� 5      -   5        $��searchButton��5   *   $��Search��6   $��320,107,0,0q�6?   $��33��6T   $	��Top=�6`   $
��Left=�6x   $��67��6�   &   System.Windows.Controls.DataGrid  5      -   5        $��studentListDataGrid��5      $��
10,145,0,0q�66   $
��Left=�6J   $	��377��6e   $	��195��6q   $	��Top=�6~      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ 
Department��6g   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6-   �� 
 �� Path$
 DepartmentName�6g     5!      $ Semester��6Q    . 	 6-   �� $
 
SemesterNo�6d     5"      $
 Year��6T    . 	 6-   �� $
 AccadamicYear�6b     5#      $ Student Name��6T    . 	 6-   �� $
 ApplicantName�6j   4  .System.Windows.Controls.DataGridTemplateColumn  5%       5&      �� 5'   "   -   5        $��CheckALL��5'   +   $��Discontinue All��6;   {�.  6U      CellTemplate 5)      �� 5*   "   .R�5+   &   �� $��chkDiscontinue��6/   -   5        $��45 2 0 0q�5+   E    d� 	IsChecked 6W   �� *	IsChecked+ �� ElementName$ CheckALL�� �� Mode$ OneWay=�5,   O   5-   #   5/      53      �� 54      -   5         ��Name$ sentSMS��54   :   $
��Bold"�6   $
��Sent��6+   $��581,324,0,0q�6K   $��24��6`   $	��Top=�6l   $
��Left=�6�   $	��111��6�   �� 55      -   5        $ ClearSmsTextButton��55   @   $
��Bold"�6   $��
Clear Text��6+   $��465,324,0,0q�6\   $��24��6q   $	��Top=�6}   $
��Left=�6�   $	��111��6�   �� 57      -   5         ��Name$ semesterCombobox��5:   
   $ 0.037,0.146&�59   
   $��	96,41,0,0q�5:   $   $
��Left=�67   $	��219��6R   $��33��6^   $	��Top=�6j   ��5<      �� 5=      .R�5>      �� $ 
Horizontal=�6)   .+�5@   "   �� $	��130��6H   ��6,   �� *
SemesterNo+6H   5B      5C      5E      �� 5F      -	   5        $ campusCombobox��5H   
   $ 0.037,0.146&�5G   
   $��	96,74,0,0q�5H   "   $
��Left=�65   $	��219��6P   $��33��6\   $	��Top=�6h   ��5J      �� 5K      .R�5L      �� $ 
Horizontal=�6)   .+�5N   "   �� $	��130��6H   ��6,   �� *
CampusName+6H   5P      5Q      5S      �� 5T      -
   5        $��yearCombobox��5V   
   $ 0.037,0.146&�5U   
   $��
96,107,0,0q�5V      $
��Left=�62   $	��219��6M   $��33��6Y   $	��Top=�6e   ��5X      �� 5Y      .R�5Z      �� $ 
Horizontal=�6)   .+�5\   "   �� $	��130��6B   ��6,   �� *Year+6B   5^      5_      5a      �� 5b      $��Departmeent��6   $
��Left=�6.   $��	10,15,0,0q�6I   $	��Top=�6\   $��81��6t   �� 5c      $��Semester��6   $
��Left=�6+   $��	10,41,0,0q�6F   $	��Top=�6Y   $��81��6q   �� 5d      $��Campus��6   $
��Left=�6)   $��	10,74,0,0q�6D   $	��Top=�6W   $��81��6o   �� 5e      $
��Year��6   $
��Left=�6'   $��
15,107,0,0q�6B   $	��Top=�6V   $��81��6n   �� 5f       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6/   $��398,171,0,0q�6C   $
��Left=�6X   $	��296��6s   $	��148��6   $	��Top=�6�   �� 5g      $��SMS Text��6   $
��Left=�6+   $��392,145,0,0q�6F   $	��Top=�6[   $��81��6s   �� 5h      $��Single Search��6   $
��Left=�62   $��	400,3,0,0q�6M   $	��Top=�6`   $	��137��6x   $	��296��6�   .��5j      � .+�5k      �� $��Student Name��6    $
��Left=�67   $��	10,10,0,0q�6R   $	��Top=�6e   �� 5l      $��
Student ID��6    $
��Left=�65   $��	10,41,0,0q�6P   $	��Top=�6c   �� 5m      $
��Left=�6"   $��30��6=   $��
110,10,0,0q�6I   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��164��6�   �� 5n      $
��Left=�6"   $��30��6=   $��
110,41,0,0q�6I   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��164��6�   �� 5o      -   5        $��	addButton��5o   /   $	��Add��6!   $��
207,76,0,0q�6A   $��33��6U   $	��Top=�6a   $
��Left=�6y   $��67��6�   5q      5r      5u      5v      5w      5x      