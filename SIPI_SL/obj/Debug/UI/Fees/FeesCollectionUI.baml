   M S B A M L   `   `   `  ����  SIPI_SL&     SIPI_SL.UI.Fees.FeesCollectionUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Fees Collection UI��5   	   $��493.304��6$   $��815.627��65    � ShowInTaskbar .     	GrayWhite#��[  6[    � WindowStartupLocation$ CenterScreen=�6�   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��285* �6   �� 5      $
��523* �6   .+�5
   
   �� $��Student Info��6   $
��Left=�6)   $��	36,10,0,0q�6D   $	��Top=�6W   $��77��6o   $	��746��6{   $
��Bold"�6�   $��2��6�   .��5      � .+�5      �� $
��Name��6   $
��Left=�6'   $��10,0,0,0q�6B   $	��Top=�6T   $��86��6l   �� 5      -   5        $��nameTextBox��5   �   $
��Left=�6   $��23��65   $��	101,3,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $	��Top=�6j   $	��243��6�   6�   �� 5      $��
Department��6   $
��Left=�6-   $��	10,19,0,0q�6H   $	��Top=�6[   $��86��6s   �� 5      -   5        $��DepartmentTextBox��5   �   $
��Left=�6   $��23��65   $��
101,28,0,0q�6A   $
 Wrap=�6U   $	��Top=�6k   $	��243��6�   6�   �� 5      $��Id��6   $
��Left=�6%   $��	460,3,0,0q�6@   $	��Top=�6S   $��37��6k   $��24��6v   �� 5      -   5        $��studentIdTextBox��5   �   $
��Left=�6   $��23��65   $��	502,3,0,0q�6A   $
 Wrap=�6T   $	��Top=�6h   $	��222��6�   6�   �� 5      -   5        $��getStudentPopupButton��5   �   $��Get Student��6   $
��Left=�6/   $��	357,2,0,0q�6J   $	��Top=�6]   $��83��6u   $��24��6�   6�   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��FeesCollectionDataGrid��5   l      AutoGenerateColumns .  $	��260��6/   $
��Left=�6<   $��106,131,0,0q�6W   $	��Top=�6�   $	��427��6�      CanUserAddRows .  $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly . 	   Header$	 Fees Details Name��67   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 250 6{   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   ��  �� Path$ FeesDetailsName�6{   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 Fees Amount��6)   $	
 150 6>    .    CellTemplate 5      �� 5      .R�5       �� $	��txt��6>   ��6&   �� *Amount+6>   5!      5#      5&      �� 5'   
   -   5        $��totalTextBox��5'   M   $
��Left=�6   $��23��6-   $��
94,400,0,0q�69   $
 Wrap=�6a   $	��Top=�6w   $	��147��6�   $��1��6�   {�.  6�   �� 5(   
   -   5        $��paidAmountTextBox��5(   N   $
��Left=�6   $��23��6-   $��185,399,0,0q�69   $
 Wrap=�6g   $	��Top=�6{   $	��147��6�   $��2��6�   {�.  6�   �� 5)   
   -   5        $��receiveAmount��5)   N   $
��Left=�6   $��23��6-   $��386,159,0,0q�69   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   $��1��6�   6�   �� 5*   
   $��Total��6   $
��Left=�6    $��
52,398,0,0q�6;   $	��Top=�6O   $
��Bold"�6g   $��1��6y   �� 5+   
   $��Paid amount��6   $
��Left=�6&   $��
98,397,0,0q�6A   $	��Top=�6U   $
��Bold"�6m    J� RenderTransformOrigin$ -1.476,-0.154&�6   �� 5,   
   $��Recive Amount��6   $
��Left=�6(   $��268,157,0,0q�6C   $	��Top=�6X   $
��Bold"�6p   $��1��6�   �� 5.   
   -	   5         ��Name$ semesterCombobax��5/      $
��Left=�5.      $��
106,92,0,0q�6.   $	��Top=�6C   $	��189��6[     ComboBoxBGYellowGreen#��[ 50      $��2��6B   ��51      �� 52      .R�53      ��  �� Orientation$ 
Horizontal=�6!   .+�54      �� $��60��6@   ��6$   �� *
SemesterNo+6@   57      58      5:      �� 5;   
   $��Semester��6   $
��Left=�6#   $��	36,92,0,0q�6>   $	��Top=�6Q   $��62��6i   $
��Bold"�6u   �� 5=   
   -
   5        $��yearCombobox��5=   e   $
��Left=�6   $��	77,92,0,0q�6.   $	��Top=�6A   $	��120��6Y   #��[ 5>   	   $��1��68   �� 5?   
   $
��Year��6   $
��Left=�6   $��	15,92,0,0q�6:   $	��Top=�6M   $��62��6e   $
��Bold"�6p   $��1��6�   �� 5@   
   -   5        $��dueAmountTextBox��5@   N   $
��Left=�6   $��23��6-   $��386,184,0,0q�69   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   $��1��6�   {�.  6�   �� 5A   
   $��
Due amount��6   $
��Left=�6%   $��268,182,0,0q�6@   $	��Top=�6U   $
��Bold"�6m   $��1��6   �� 5B   
   -   5        $��feesCollectionDaveButton��5B       $
��Save��6   $
��Left=�6g   $��328,401,0,0q�6�   $	��Top=�6�   $��75��6�   $ 0.493,-0.05&�6�   $��1��6�   (  "System.Windows.Controls.DatePicker  5C   
   -   5        $��collectionDateDatePicker��5C   i   $
��Left=�6   $��387,214,0,0q�60   $	��Top=�6E   $	��120��6]   $��1��6�   �� 5D   
   $��Collection date��6   $
��Left=�6*   $��268,212,0,0q�6E   $	��Top=�6Z   $
��Bold"�6r   $��1��6�   �� 5E   
   -   5         ��Name$ receivableAmount��5E   N   $
��Left=�6   $��23��6-   $��386,133,0,0q�69   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   $��1��6�   {�.  6�   �� 5F   
   $��Receivable Amount��6   $
��Left=�6,   $��268,131,0,0q�6G   $	��Top=�6\   $
��Bold"�6t   $��1��6�   5H      5I      