   M S B A M L   `   `   `  ����   SIPI_SL;    5SIPI_SL.Report.UI.StudentFees.FeesCollectionHistoryUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Fees Collection UI��$��569.996��$��990.439�� � ShowInTaskbar .     	GrayWhite#��[   � WindowStartupLocation$ CenterScreen=�.��� .+��� $��Fees Colletion History��$
��Left=�$��	36,10,0,0q�$	��Top=�$��71��$	��902��$
��Bold"�.��� .+��� -   $��CampusComboBox��$
��Left=�$��	576,8,0,0q�$	��Top=�$	��172��  ComboBoxBGYellowGreen#��[ $��29���� $��	From Date��$
��Left=�$��	10,10,0,0q�$	��Top=�$��86���� $��To Date��$
��Left=�$��
293,10,0,0q�$	��Top=�$��64��$��24���� -    ��Name$ getStudentPopupButton��$��Search��$
��Left=�$��
753,10,0,0q�$	��Top=�$��83��$��24��(  "System.Windows.Controls.DatePicker  -   $��startDateDatepicker��$
��Left=�$��	85,12,0,0q�$	��Top=�$	��203��  -   $��endDateDatepicker��$
��Left=�$��
357,11,0,0q�$	��Top=�$	��214���� $��Fees Collection List��$
��Left=�$��	36,86,0,0q�$	��Top=�$	��401��$	��902��.���� -   $��feesCollectionlistView��$��2,6,-2,0q�$��1��$
��Left=�$	��890��   alternatingListViewItemStyle#��[ $	��369��$	��Top=� � ContextMenu �� -   $��ZoneIformationList�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -   $��EditThanaContextMenu��$��Preview�� �� View ��  �� AllowsColumnReorder . .P��� $�� ��	 �� Width$	 0��
 �� DisplayMemberBinding
 ��  �� Path$ Id��� $��StudentName��$		 200��
 �� $ StudentName��� $��Department Name��$		 280��
 �� $ 
Department��� $��Semester��$		 100��
 �� $ Semester��� $
��Date��$		 100��
 �� $ CollectionDate��� $��Receive Amount��$		 150��
 �� $ ReceiveAmount��� -   $��Preview��$
��Left=�$��863,492,0,0q�$	��Top=�$��75��