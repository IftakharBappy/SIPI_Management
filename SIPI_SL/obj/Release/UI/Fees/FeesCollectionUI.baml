   M S B A M L   `   `   `  ����   SIPI_SL&     SIPI_SL.UI.Fees.FeesCollectionUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Fees Collection UI��$��493.304��$��815.627�� � ShowInTaskbar .     	GrayWhite#��[   � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� $
��285* ��� $
��523* �.+��� $��Student Info��$
��Left=�$��	36,10,0,0q�$	��Top=�$��77��$	��746��$
��Bold"�$��2��.��� .+��� $
��Name��$
��Left=�$��10,0,0,0q�$	��Top=�$��86���� -   $��nameTextBox��$
��Left=�$��23��$��	101,3,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��243���� $��
Department��$
��Left=�$��	10,19,0,0q�$	��Top=�$��86���� -   $��DepartmentTextBox��$
��Left=�$��23��$��
101,28,0,0q�$
 Wrap=�$	��Top=�$	��243���� $��Id��$
��Left=�$��	460,3,0,0q�$	��Top=�$��37��$��24���� -   $��studentIdTextBox��$
��Left=�$��23��$��	502,3,0,0q�$
 Wrap=�$	��Top=�$	��222���� -   $��getStudentPopupButton��$��Get Student��$
��Left=�$��	357,2,0,0q�$	��Top=�$��83��$��24��&   System.Windows.Controls.DataGrid  -   $��FeesCollectionDataGrid��   AutoGenerateColumns .  $	��260��$
��Left=�$��106,131,0,0q�$	��Top=�$	��427��   CanUserAddRows .  $��2��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly . 	   Header$	 Fees Details Name��
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 250 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ FeesDetailsName�4  .System.Windows.Controls.DataGridTemplateColumn  $	 Fees Amount��$	
 150  .    CellTemplate �� .R��� $	��txt������ *Amount+�� -   $��totalTextBox��$
��Left=�$��23��$��
94,400,0,0q�$
 Wrap=�$	��Top=�$	��147��$��1��{�.  �� -   $��paidAmountTextBox��$
��Left=�$��23��$��185,399,0,0q�$
 Wrap=�$	��Top=�$	��147��$��2��{�.  �� -   $��receiveAmount��$
��Left=�$��23��$��386,159,0,0q�$
 Wrap=�$	��Top=�$	��120��$��1���� $��Total��$
��Left=�$��
52,398,0,0q�$	��Top=�$
��Bold"�$��1���� $��Paid amount��$
��Left=�$��
98,397,0,0q�$	��Top=�$
��Bold"� J� RenderTransformOrigin$ -1.476,-0.154&��� $��Recive Amount��$
��Left=�$��268,157,0,0q�$	��Top=�$
��Bold"�$��1���� -	    ��Name$ semesterCombobax��$
��Left=�$��
106,92,0,0q�$	��Top=�$	��189��  ComboBoxBGYellowGreen#��[ $��2������ .R���  �� Orientation$ 
Horizontal=�.+��� $��60������ *
SemesterNo+�� $��Semester��$
��Left=�$��	36,92,0,0q�$	��Top=�$��62��$
��Bold"��� -
   $��yearCombobox��$
��Left=�$��	77,92,0,0q�$	��Top=�$	��120��#��[ $��1���� $
��Year��$
��Left=�$��	15,92,0,0q�$	��Top=�$��62��$
��Bold"�$��1���� -   $��dueAmountTextBox��$
��Left=�$��23��$��386,184,0,0q�$
 Wrap=�$	��Top=�$	��120��$��1��{�.  �� $��
Due amount��$
��Left=�$��268,182,0,0q�$	��Top=�$
��Bold"�$��1���� -   $��feesCollectionDaveButton��$
��Save��$
��Left=�$��328,401,0,0q�$	��Top=�$��75��$ 0.493,-0.05&�$��1��(  "System.Windows.Controls.DatePicker  -   $��collectionDateDatePicker��$
��Left=�$��387,214,0,0q�$	��Top=�$	��120��$��1���� $��Collection date��$
��Left=�$��268,212,0,0q�$	��Top=�$
��Bold"�$��1���� -    ��Name$ receivableAmount��$
��Left=�$��23��$��386,133,0,0q�$
 Wrap=�$	��Top=�$	��120��$��1��{�.  �� $��Receivable Amount��$
��Left=�$��268,131,0,0q�$	��Top=�$
��Bold"�$��1��