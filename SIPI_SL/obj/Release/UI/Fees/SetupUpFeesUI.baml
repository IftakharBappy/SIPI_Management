   M S B A M L   `   `   `  ����   SIPI_SL#    SIPI_SL.UI.Fees.SetupUpFeesUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
Setup Fees��$��513.03��$��774.284�� � ShowInTaskbar .   � 
ResizeMode$ CanMinimize=� � WindowStartupLocation$ CenterScreen=�   	GrayWhite#��[  .��� .+��� -    ��Name$ label2��$ ��Department wise Fees Setup��$��LeftToRight=�$��18(�$
��Bold"�$��33��$��259,0,244,0q�$	��Top=�$��Center=�$	��265���� -    ��Name$ DepartmentComboBox��$
��Left=�$��
123,49,0,0q�$	��Top=�$	��277��  ComboBoxBGYellowGreen#��[ �� $��
Department��$
��Left=�$��	45,53,0,0q�$	��Top=�$��89���� -   $ SemesterComboBox��$
��Left=�$��
474,49,0,0q�$	��Top=�$	��105��#��[ �� $��Semester��$
��Left=�$��
414,53,0,0q�$	��Top=�$	��124���� -   $ YearComboBox��$
��Left=�$��
628,49,0,0q�$	��Top=�$��95��#��[ �� $
��Year��$
��Left=�$��
584,53,0,0q�$	��Top=�$��44��&   System.Windows.Controls.DataGrid  -   $��setupFeesDataGrid��   AutoGenerateColumns .  $	��254��$
��Left=�$��
43,145,0,0q�$	��Top=�$	��683��   CanUserAddRows .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   
IsReadOnly	 . 
   Header$
 Fees Details Name��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 400 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ FeesName�4  .System.Windows.Controls.DataGridTemplateColumn  	 . $
 Fees Amount��$	 250    CellTemplate �� .R��� $��feesAmountTextBox��-   ���� $ 
FeesAmount� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� -   $��totalTextBox��$
��Left=�$��23��$��446,404,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��277���� $��Total��$
��Left=�$��397,404,0,0q�$	��Top=�$��49��$��23���� -   $
��Save��$
��Left=�$��648,432,0,0q�$	��Top=�$��75���� -	   $��CampusComboBox��$
��Left=�$��
123,93,0,0q�$	��Top=�$	��277��#��[ �� $��Campus��$
��Left=�$��	45,97,0,0q�$	��Top=�$��89��