   M S B A M L   `   `   `  ����  SIPI_SL;    5SIPI_SL.Report.UI.StudentFees.FeesCollectionHistoryUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Fees Collection UI��5   	   $��569.996��6$   $��990.439��65    � ShowInTaskbar .     	GrayWhite#��[  6[    � WindowStartupLocation$ CenterScreen=�6�   .��5      � .+�5   
   �� $��Fees Colletion History��6   $
��Left=�63   $��	36,10,0,0q�6N   $	��Top=�6a   $��71��6y   $	��902��6�   $
��Bold"�6�   .��5      � .+�5      �� -   5        $��CampusComboBox��5   m   $
��Left=�6   $��	576,8,0,0q�66   $	��Top=�6I   $	��172��6a     ComboBoxBGYellowGreen#��[ 6�   $��29��6�   �� 5
      $��	From Date��6   $
��Left=�6,   $��	10,10,0,0q�6G   $	��Top=�6Z   $��86��6r   �� 5      $��To Date��6   $
��Left=�6*   $��
293,10,0,0q�6E   $	��Top=�6Y   $��64��6q   $��24��6|   �� 5      -   5         ��Name$ getStudentPopupButton��5   �   $��Search��6   $
��Left=�6*   $��
753,10,0,0q�6E   $	��Top=�6Y   $��83��6q   $��24��6|   6�   (  "System.Windows.Controls.DatePicker  5      -   5        $��startDateDatepicker��5   o   $
��Left=�6   $��	85,12,0,0q�68   $	��Top=�6K   $	��203��6c   6o     5      -   5        $��endDateDatepicker��5   p   $
��Left=�6   $��
357,11,0,0q�68   $	��Top=�6L   $	��214��6d   6p   5      5      �� 5   
   $��Fees Collection List��6   $
��Left=�61   $��	36,86,0,0q�6L   $	��Top=�6_   $	��401��6w   $	��902��6�   .��5      �� -   5        $��feesCollectionlistView��5      $��2,6,-2,0q�5      $��1��5   7   $
��Left=�6G   $	��890��6b      alternatingListViewItemStyle#��[ 5      $	��369��6^   $	��Top=�6k    � ContextMenu 5      �� 5      -   5        $��ZoneIformationList��5   "    �� 	StaysOpen . 
������� J� BitmapEffect 5      �� 5       .@�5"      m� -   5        $��EditThanaContextMenu��5"   4   $��Preview��6#   6P   5$       �� View 5&      �� 5'       �� AllowsColumnReorder . .P�5(      �� $�� ��6R   	 �� Width$	 0��6\   
 �� DisplayMemberBinding
 6)   ��  �� Path$ Id�6\   �� 5)      $��StudentName��6[   $		 200��6p   
 6)   �� $ StudentName�6p   �� 5*      $��Department Name��6Z   $		 280��6s   
 6)   �� $ 
Department�6s   �� 5+      $��Semester��6X   $		 100��6j   
 6)   �� $ Semester�6j   �� 5,      $
��Date��6^   $		 100��6l   
 6)   �� $ CollectionDate�6l   �� 5-      $��Receive Amount��6]   $		 150��6u   
 6)   �� $ ReceiveAmount�6u   5/      51      52      �� 53   
   -   5        $��Preview��53      $
��Left=�6#   $��863,492,0,0q�6>   $	��Top=�6S   $��75��6k   6v   55      56      