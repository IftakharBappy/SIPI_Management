   M S B A M L   `   `   `  ����  SIPI_SL)    #SIPI_SL.UI.Admission.ViewAllStudent   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ViewAllStudent��5   	   $��674.055��6    $��1209.143��61    � WindowStartupLocation$ CenterScreen=�6B   .��5      � $��	0,10,0,-1q�6   .+�5   
   � .+�5	      �� $��Search��6   $	��Top=�6'   $��62��6?   $��0,0,10,0q�6K   .��5
      � .+�5      �� $
��Name��6   $
��Left=�6+   $��	10,10,0,0q�6F   $	��Top=�6Y   �� 5      $��Mobile��6   $
��Left=�6-   $��
198,10,0,0q�6H   $	��Top=�6\   �� 5      $��Campus��6   $
��Left=�6-   $��
401,10,0,0q�6H   $	��Top=�6\    J� RenderTransformOrigin$ 3.786,0.635&�6t   �� 5      $��Dartment��6   $
��Left=�6/   $��
602,10,0,0q�6J   $	��Top=�6^   $ 3.786,0.635&�6v   �� 5      $��
Student Id��6   $
��Left=�61   $��	813,7,0,0q�6L   $	��Top=�6_   $ 3.786,0.635&�6w   �� 5      $��Search��6   $
��Left=�6.   $��37��6I   $��
1054,0,0,0q�6U   $	��Top=�6i   $	��102��6�   �� 5      $
��Left=�6   $��23��69    �� TextWrapping$
 Wrap=�6E   $�� ��6Y   $	��Top=�6b   $	��120��6z   $��	73,13,0,0q�6�   �� 5      $
��Left=�6   $��23��69   $
 Wrap=�6E   $�� ��6Y   $	��Top=�6b   $	��120��6z   $��
260,13,0,0q�6�   �� 5      $
��Left=�6   $��23��69   $
 Wrap=�6E   $�� ��6Y   $	��Top=�6b   $	��120��6z   $��
462,13,0,0q�6�   �� 5      $
��Left=�6   $��23��69   $
 Wrap=�6E   $�� ��6Y   $	��Top=�6b   $	��120��6z   $��
688,11,0,0q�6�   �� 5      $
��Left=�6   $��23��69   $
 Wrap=�6E   $�� ��6Y   $	��Top=�6b   $	��120��6z   $��
885,11,0,0q�6�   5      5      �� 5      $��All Students��6   $��0,67,0,0q�6-   .��5      � $
��Left=�6   $	��Top=�63   .+�5      �� -   5        $��studentInofListView��5    '   $��1,10,-4,-556q�5          alternatingListViewItemStyle#��[  5!       �� AlternationCount$ 2��6b    �� View 5#      �� 5$       �� AllowsColumnReorder . .P�5%   "   �� $	��S.L��6Z    �� Width$ 30��6g    �� DisplayMemberBinding 61   �� 	 �� Path$	 Id�6g   �� 5&   "   $��Student Name��6e   $	 100��6{    61   �� $	 ApplicantName�6{   �� 5'   "   $��Student Nobile��6`   $	 100��6x    61   �� $	 MobileNo�6x   �� 5(   "   $��Father Name��6b   $	 100��6w    61   �� $	 
FatherName�6w   �� 5)   "   $��Mother Name��6b   $	 100��6w    61   �� $	 
MotherName�6w   �� 5*   "   $��Father's Mobile��6g   $	 100��6�    61   �� $	 FathersMobileNo�6�   �� 5+   "   $��Guardian Name��6d   $	 100��6{    61   �� $	 GuardianName�6{   �� 5,   "   $��Guardian Mobile��6h   $	 100��6�    61   �� $	 GuardianMobileNo�6�   �� 5-   "   $��Program��6c   $	 100��6t    61   �� $	 ProgramName�6t   �� 5.   "   $��
Department��6f   $	 100��6z    61   �� $	 DepartmentName�6z   �� 5/   "   $��Campus��6b   $	 100��6r    61   �� $	 
CampusName�6r   �� 50   "   $
��Exam��6m   $	 100��6{    61   �� $	 AccadamicInfo_ExamNme�6{   �� 51   "   $��Group��6k   $	 100��6z    61   �� $	 AccadamicInfo_Group�6z   �� 52   "   $	��GPA��6i   $	 100��6v    61   �� $	 AccadamicInfo_GPA�6v   �� 53   "   $��PassingYear��6q   $	 100��6�    61   �� $	 AccadamicInfo_PassingYear�6�   57      59      5G      5H      5I      5L      5M      