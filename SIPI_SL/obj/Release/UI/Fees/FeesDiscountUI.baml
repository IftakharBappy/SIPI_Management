   M S B A M L   `   `   `  ����   SIPI_SL$    SIPI_SL.UI.Fees.FeesDiscountUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Fees Discount UI��$��525.657��$��814.638�� � ShowInTaskbar .     	GrayWhite#��[   � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� $
��308* ��� $
��485* �.+��� $��Student Info��$
��Left=�$��	10,21,0,0q�$	��Top=�$��77��$	��773��$
��Bold"�$��2��.��� .+��� $
��Name��$
��Left=�$��10,0,0,0q�$	��Top=�$	��106���� -   $��nameTextBox��$
��Left=�$��23��$��75,0,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��247���� $��
Department��$
��Left=�$��
342,-3,0,0q�$	��Top=�$	��106���� -   $��DepartmentTextBox��$
��Left=�$��23��$��	425,0,0,0q�$
 Wrap=�$	��Top=�$	��326���� $��Id��$
��Left=�$��	10,30,0,0q�$	��Top=�$��82��$��24���� -   $��	idTextBox��$
��Left=�$��23��$��	75,31,0,0q�$
 Wrap=�$	��Top=�$	��247���� -   $��getStudentPopupButton��$��Get Student��$
��Left=�$��
425,28,0,0q�$	��Top=�$��83��$��24��&   System.Windows.Controls.DataGrid  -   $��setupFeesDataGrid��   AutoGenerateColumns .  $	��202��$
��Left=�$��
25,143,0,0q�$	��Top=�$	��744��   CanUserAddRows .  $��2��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly . 	   Header$	 Fees Details Name��
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 450 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ FeesName�4  .System.Windows.Controls.DataGridTemplateColumn   . $	 Fees Amount��$	
 250    CellTemplate �� .R��� $	��txt������ *
FeesAmount+�� $
��Left=�$��23��$��175.071,350,0,0q�$
 Wrap=�$	��Top=�$	��260��$��1���� $
��Left=�$��23��$��175.071,376,0,0q�$
 Wrap=�$	��Top=�$	��260��$��1���� $
��Left=�$��23��$��175.071,404,0,0q�$
 Wrap=�$	��Top=�$	��260��$��1���� $��Total��$
��Left=�$��123.071,350,0,0q�$	��Top=�$
��Bold"�$��1���� $��Discount��$
��Left=�$��101.071,373,0,0q�$	��Top=�$
��Bold"� J� RenderTransformOrigin$ 2.656,0.526&�$��1���� $��Payable Amount��$
��Left=�$��58.071,401,0,0q�$	��Top=�$
��Bold"�$��1���� -    ��Name$ semesterCombobax��$
��Left=�$��106,104,0,0q�$	��Top=�$	��155��  ComboBoxBGYellowGreen#��[ ���� .R���  �� Orientation$ 
Horizontal=�.+��� $��60������ *
SemesterNo+�� $��Semester��$
��Left=�$��
25,107,0,0q�$	��Top=�$��62��$
��Bold"��� -   $��yearCombobox��$
��Left=�$��
30,103,0,0q�$	��Top=�$	��120��#��[ $��1���� $
��Year��$
��Left=�$��281,107,0,0q�$	��Top=�$��62��$
��Bold"�$��2��