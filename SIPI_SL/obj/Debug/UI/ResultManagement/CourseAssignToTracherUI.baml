   M S B A M L   `   `   `  ����  SIPI_SL9    3SIPI_SL.UI.ResultManagement.CourseAssignToTracherUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$!  Course Assign To Teacher UI��5   	   $��444.781��6-   $��803.231��6>    � WindowState$ 	Maximized=�5   	    � WindowStartupLocation$ CenterScreen=�6!    � 
ResizeMode$ CanMinimize=�5   	      	GrayWhite#��[  6#    � ShowInTaskbar .  .��5      � .+�5	   
   �� $
��Left=�6   $��
128,28,0,0q�6.   $	��Top=�6B   $	��254��6Z     ComboBoxBGYellowGreen#��[ 6f   �� 5
   
   $��
Department��6   $
��Left=�6&   $��	15,37,0,0q�6A   $	��Top=�6T   $	��106��6l   �� 5   
   $
��Left=�6   $��
128,70,0,0q�6.   $	��Top=�6B   $	��130��6Z   #��[ 6f   �� 5   
   $
��Year��6   $
��Left=�6    $��	16,73,0,0q�6;   $	��Top=�6N   $��66��6f   �� 5   
   $�� ��6   $
��Left=�6   $��
263,70,0,0q�67   $	��Top=�6K   $	��119��6c   $��51��6o     SearchButton#���  6{   �� 5   
   $��Assign��6   $
��Left=�6"   $��677,365,0,0q�6=   $	��Top=�6R   $	��108��6j   $��36��6v   &   System.Windows.Controls.DataGrid  5   
   -   5        $��StudentListDataGrid��5   !      AutoGenerateColumns .  $	��219��5      $
��Left=�6   $��
16,141,0,0q�5      $	��Top=�5      $	��400��6%      CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Teacher's Name��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 6d   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6=   ��  �� Path$ ApplicantName�6d     5      $ Teacher Code��6%   $
	 auto 6^   
 6;   �� $ 	StudentId�6^   4  .System.Windows.Controls.DataGridTemplateColumn  5       5      �� 5      -   5        $��CheckALL��5   #   $��
Select All��63   {�.  6H      CellTemplate 5!      �� 5"      .R�5#      �� $��chkDiscontinue��6'   -   5        $��45 2 0 0q�5#   =    d� 	IsChecked 6O   �� *	IsChecked+ �� ElementName$ CheckALL�� �� Mode$ OneWay=�5$   O   5%      5'      5,        5-   
   -   5        $��CourseListDataGrid��50   "    .  $	��219��5/      $��421,141,0,0q�50      $	��Top=�51       .  $
��Left=�52   $   $	��364��6?    54        55      $ 
Department��6%   $
	 auto 6b   
 69   �� $ SIPI_Department�6b     56      $ Semester��6%   $
	 auto 6[   
 67   �� $ 
SemesterNo�6[     57      $ Course Name��6%   $
	 auto 6^   
 6:   �� $ 
CourseName�6^     58      $ 	Course Id��6%   $
	 auto 6Z   
 68   �� $ CourseId�6Z   5:      �� 5;   
   $
��Left=�6   $��
554,28,0,0q�6.   $	��Top=�6B   $	��156��6Z   #��[ 6f   �� 5<   
   $��Assign to Semester Course��6   $
��Left=�65   $��
388,33,0,0q�6P   $	��Top=�6d   $	��166��6|   5=      5>      