   M S B A M L   `   `   `  ����   SIPI_SL5    /SIPI_SL.UI.SMSManagement.SMSManagementDeshboard   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$!  SMS Management Deshboard UI��$��474.466�� � WindowState$ 	Maximized=� � WindowStartupLocation$ CenterScreen=�   	GrayWhite#��[   � ShowInTaskbar .  $��774.104��.��� .+��� $	��SMS��$��Center=�$��
33,10,25,0q�$	��Top=�$	��708��$	��387��.��� .+��� -   $��departmentCombobox�� J� RenderTransformOrigin$ 0.037,0.146&�$��96,8,0,0q�$
��Left=�$	��219��$��33��$	��Top=����� .R���  �� Orientation$ 
Horizontal=�.+��� $	��130������ *SIPI_DepartmentName+�� -   $��searchButton��$��Search��$��320,107,0,0q�$��33��$	��Top=�$
��Left=�$��67��&   System.Windows.Controls.DataGrid  -   $��studentListDataGrid��$��
10,145,0,0q�$
��Left=�$	��377��$	��195��$	��Top=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ 
Department��1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� 
 �� Path$
 DepartmentName�  $ Semester�� . 	 �� $
 
SemesterNo�  $
 Year�� . 	 �� $
 AccadamicYear�  $ Student Name�� . 	 �� $
 ApplicantName�4  .System.Windows.Controls.DataGridTemplateColumn   �� -   $��CheckALL��$��Discontinue All��{�.     CellTemplate �� .R��� $��chkDiscontinue��-   $��45 2 0 0q� d� 	IsChecked �� *	IsChecked+ �� ElementName$ CheckALL�� �� Mode$ OneWay=��� -    ��Name$ sentSMS��$
��Bold"�$
��Sent��$��581,324,0,0q�$��24��$	��Top=�$
��Left=�$	��111���� -   $ ClearSmsTextButton��$
��Bold"�$��
Clear Text��$��465,324,0,0q�$��24��$	��Top=�$
��Left=�$	��111���� -    ��Name$ semesterCombobox��$ 0.037,0.146&�$��	96,41,0,0q�$
��Left=�$	��219��$��33��$	��Top=����� .R��� $ 
Horizontal=�.+��� $	��130������ *
SemesterNo+�� -	   $ campusCombobox��$ 0.037,0.146&�$��	96,74,0,0q�$
��Left=�$	��219��$��33��$	��Top=����� .R��� $ 
Horizontal=�.+��� $	��130������ *
CampusName+�� -
   $��yearCombobox��$ 0.037,0.146&�$��
96,107,0,0q�$
��Left=�$	��219��$��33��$	��Top=����� .R��� $ 
Horizontal=�.+��� $	��130������ *Year+�� $��Departmeent��$
��Left=�$��	10,15,0,0q�$	��Top=�$��81���� $��Semester��$
��Left=�$��	10,41,0,0q�$	��Top=�$��81���� $��Campus��$
��Left=�$��	10,74,0,0q�$	��Top=�$��81���� $
��Year��$
��Left=�$��
15,107,0,0q�$	��Top=�$��81����  �� AcceptsReturn .  �� TextWrapping$
 Wrap=�$��398,171,0,0q�$
��Left=�$	��296��$	��148��$	��Top=��� $��SMS Text��$
��Left=�$��392,145,0,0q�$	��Top=�$��81���� $��Single Search��$
��Left=�$��	400,3,0,0q�$	��Top=�$	��137��$	��296��.��� .+��� $��Student Name��$
��Left=�$��	10,10,0,0q�$	��Top=��� $��
Student ID��$
��Left=�$��	10,41,0,0q�$	��Top=��� $
��Left=�$��30��$��
110,10,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��164���� $
��Left=�$��30��$��
110,41,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��164���� -   $��	addButton��$	��Add��$��
207,76,0,0q�$��33��$	��Top=�$
��Left=�$��67��