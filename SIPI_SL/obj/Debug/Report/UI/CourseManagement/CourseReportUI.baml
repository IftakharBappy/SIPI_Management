   M S B A M L   `   `   `  ����  SIPI_SL7    1SIPI_SL.Report.UI.CourseManagement.CourseReportUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Course Report��5   	   $��353.356��6   $��621.197��60      	GrayWhite#��[  6A    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6   .��5      � .+�5   
   � .+�5      �� -   5        $��previewReportButton��5   �   $��Preview��6   $
��Left=�6'   $	��Top=�6B   $��75��6Z   $��
514,35,0,0q�6e   $��24��6y   6�   �� 5	      -   5        $��searchButton��5	   �   $��Search��6   $
��Left=�6&   $	��Top=�6A   $��75��6Y   $��
433,35,0,0q�6d   $��24��6x   6�   �� 5
      -   5        $��departmentCombobox��5   !    �� 
IsEditable .  w� TextPath$ SIPI_DepartmentName��5   !   $
��Left=�5   !   $��	51,35,0,0q�5   !   $	��Top=�5   !   $	��238��5   !    J� RenderTransformOrigin$ 0.037,0.146&�5   !   $��33��5   ;   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $	��238��6M   ��6(   �� *SIPI_DepartmentName+6M   5      5      5      �� 5      -   5         ��Name$ semesterCombobox��5%       . $ 
SemesterNo��5      $
��Left=�5       $��
294,34,0,0q�5!      $	��Top=�5"      $	��123��5#      $ 0.037,0.146&�5$      $��34��5%   (   ��5&      �� 5'      .R�5(      �� $ 
Horizontal=�6%   .+�5*      �� $	��130��6D   ��6(   �� *
SemesterNo+6D   5,      5-      5/      �� 50      $��
Department��6   $
��Left=�6)   $��51,0,0,0q�6D   $	��Top=�6V   $	��164��6n   $��30��6z   $��15(�6�   $
��Bold"�6�   �� 51      $��Semester��6   $
��Left=�6'   $��
294,-1,0,0q�6B   $	��Top=�6V   $	��123��6n   $��30��6z   $��15(�6�   $
��Bold"�6�   52      �� 54   
   $��All Courses��6   $
��Left=�6(   $��	55,86,0,0q�6C   $	��Top=�6V   $	��185��6n   $	��520��6{   .��55      � $
��Left=�6   $	��162��6.   $	��Top=�6;   $	��518��6S    � ColumnDefinitions 56      �� 57      $��2* �6'   �� 58      $
��211* �6'   .+�5;      �� -   5        $��courselistView��5=      $	��156��5;      $��2,6,0,0q�5<      $	��Top=�5>      $��1��61   $
��Left=�6A   $	��501��6\      alternatingListViewItemStyle#��[ 5?      	 �� View	 5@      �� 5A      
 �� AllowsColumnReorder
 . .P�5B      �� $�� ��6V    �� Width$ 0��6`    �� DisplayMemberBinding 6-   ��  �� Path$ Id�6`   �� 5C      $��Program Name��6_   $	 100��6u    6-   �� $ ProgramName�6u   �� 5D      $��Department Name��6b   $	 100��6{    6-   �� $ DepartmentName�6{   �� 5E      $��semester��6^   $	 100��6p    6-   �� $ 
SemesterNo�6p   �� 5F      $��Course Name��6^   $	 100��6s    6-   �� $ 
CourseName�6s   �� 5G      $��Bangla Course��6d   $	 100��6{    6-   �� $ BanglaCourseName�6{   5I      5K      5L      5M      5P      5Q      