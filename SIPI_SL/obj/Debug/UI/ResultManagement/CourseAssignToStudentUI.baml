   M S B A M L   `   `   `  ����  SIPI_SL9    3SIPI_SL.UI.ResultManagement.CourseAssignToStudentUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$!  Course Assign To Student UI��5   	   $��774.781��6-   $��1247.231��6>    � WindowState$ 	Maximized=�5   	    � WindowStartupLocation$ CenterScreen=�6!    � 
ResizeMode$ CanMinimize=�5   	      	GrayWhite#��[  6#    � ShowInTaskbar .  .��5      � .+�5	   
   �� $��Student Assign��6   $��Center=�6,   $��
28,10,10,0q�6I   $	��Top=�6]   $
��1203��6u   $	��687��6�   .��5
      � .+�5      �� -   5        $��departmentCombobox��5      $
��Left=�65   $��	95,14,0,0q�6P   $	��Top=�6c   $	��254��6{     ComboBoxBGYellowGreen#��[ 6�   �� 5      $��
Department��6   $
��Left=�6.   $��7,22,0,0q�6I   $	��Top=�6[   $��79��6s   �� 5      -   5        $��semesterCombobox��5      $
��Left=�63   $��
459,14,0,0q�6N   $	��Top=�6b   $	��184��6z   #��[ 6�   �� 5      $��Current Semester��6   $
��Left=�64   $��
354,14,0,0q�6O   $	��Top=�6c   $	��105��6{   �� 5      -   5        $��yearCombobox��5      $
��Left=�6/   $��	95,54,0,0q�6J   $	��Top=�6]   $	��254��6u   #��[ 6�   �� 5      $
��Year��6   $
��Left=�6(   $��	10,53,0,0q�6C   $	��Top=�6V   $��41��6n   �� 5      -   5        $��searchButton��5   �   $�� ��6   $
��Left=�6$   $��
524,58,0,0q�6?   $	��Top=�6S   $	��119��6k   $��27��6w     SearchButton#���  6�   6�   �� 5      -   5        $��assignButton��5   �   $��Assign��6   $
��Left=�6*   $��1073,313,0,0q�6E   $	��Top=�6[   $	��108��6s   $��36��6   6�   &   System.Windows.Controls.DataGrid  5      -   5        $��studentListDataGrid��5   ,      AutoGenerateColumns .  $	��561��5      $
��Left=�6&   $��	10,90,0,0q�5      $	��Top=�5      $	��633��61      CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Department��6-   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 6j   
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ SIPI_Department�6w     5      $ Semester��6-   $
	 auto 6c   
 .  6?   �� $ 
SemesterNo�6p     5      $ Student Name��6-   $
	 auto 6j   
 .  6C   �� $ ApplicantName�6w     5      $ 
Srudent Id��6-   $
	 auto 6d   
 .  6A   �� $ 	StudentId�6q   4  .System.Windows.Controls.DataGridTemplateColumn  5!      
 .  5"      �� 5#   "   -   5        $��CheckALL��5#   +   $��
Select All��6;   {�.  6P      CellTemplate 5%      �� 5&   "   .R�5'   &   �� $��chkDiscontinue��6/   -   5        $��45 2 0 0q�5'   E    d� 	IsChecked 6W   �� *	IsChecked+ �� ElementName$ CheckALL�� �� Mode$ OneWay=�5(   O   5)   #   5+      50        51      -	   5        $��CourseListDataGrid��54   %    .  $	��219��53      $��
648,93,0,0q�54      $	��Top=�55       .  $
��Left=�56   (   $	��533��6C    58        59      $ 
Department��6-   $
	 auto 6i   
 .  6A   �� $ DepartmentName�6v     5:      $ Semester��6-   $
	 auto 6c   
 .  6?   �� $ 
SemesterNo�6p     5;      $ Course Name��6-   $
	 auto 6f   
 .  6B   �� $ 
CourseName�6s     5<      $ Course Code��6-   $
	 auto 6f   
 .  6B   �� $ 
CourseCode�6s     5=      $ Total Marks��6-   $
	 auto 6g   
 .  6B   �� $ TotalCredit�6t     5>      $ Total Marks��6-   $
	 auto 6f   
 .  6B   �� $ 
TotalMarks�6s   5B      �� 5C      -
   5        $��semesterAssignCmbBox��5C   �   $
��Left=�6   $��1025,54,0,0q�66   $	��Top=�6K   $	��156��6c   #��[ 6o   6�   �� 5D      $��Assign to Semester Course��6   $
��Left=�6=   $��
864,54,0,0q�6X   $	��Top=�6l   $	��156��6�   �� 5F      -   5        $��assignStudent��5F   [   $	��300��6   $
��Left=�6+   $��648,351,0,0q�6F   $	��Top=�6q   $	��533��6�    � ContextMenu 5G      �� 5H      -   5        $��contextformationList��5H   &    �� 	StaysOpen . 
������� J� BitmapEffect 5I      �� 5J   "   .@�5M      m� -   5        $��RemoveZoneInfoContextMenu��5M   7   $��Remove��6'   6X   5N       �� View 5P      �� 5Q      .P�5R      �� $��Id��6-    �� Width$ 0��6:    �� DisplayMemberBinding 6D   �� $ ZoneBranchId��� 5S      $��
DEpartment��6-   $
 auto��6A    6N   �� $ DepartmentName��� 5T      $
��YEAR��6-   $
 Auto��6<    6I   �� $ YearNo��� 5U      $��SEMESTER��6-   $
 auto��6@    6M   �� $ 
SemesterNo�5V      5X      5Y      5Z      5]      5^      