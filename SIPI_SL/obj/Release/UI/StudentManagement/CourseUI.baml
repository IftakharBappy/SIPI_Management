   M S B A M L   `   `   `  ����   SIPI_SL+    %SIPI_SL.UI.StudentManagement.CourseUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  	Course UI��$��577.776��$	��930��   	GrayWhite#��[   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� .+��� $��Course Name��$
��Left=�$��	24,97,0,0q�$	��Top=�$��26��$	��102���� -   $��courseNameTextBox��$
��Left=�$��23��$��
10,126,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��120��.���� $��All Courses��$
��Left=�$��	2,218,0,0q�$	��Top=�$	��319��$	��912��.��� $
��Left=�$	��902��$��
0,0,-2,-12q� �� $��2* ��� $
��211* �.+��� -   $��courselistView��$��
2,6,0,-177q�$��1��$
��Left=�$	��882��   alternatingListViewItemStyle#��[ $	��285��$	��Top=� � ContextMenu �� -   $��ZoneIformationList�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -   $��EditThanaContextMenu��$
��Edit��m� -   $��RemoveThanaContextMenu��$��Remove�� �� View �� 	 �� AllowsColumnReorder	 . .P��� $�� ��
 �� Width$
 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��Program Name��$	
 100�� �� $ ProgramName��� $��Department Name��$	
 100�� �� $ DepartmentName��� $��semester��$	
 100�� �� $ 
SemesterNo��� $��Course Name��$	
 100�� �� $ 
CourseName��� $��Bangla Course��$	
 100�� �� $ BanglaCourseName��� $��Department Name��$
��Left=�$��
374,10,0,0q�$	��Top=�$��26��$	��111���� -    ��Name$ departmentNameCombobax��$
��Left=�$��
490,10,0,0q�$	��Top=�$	��273��  ComboBoxBGYellowGreen#��[ ���� .R���  �� Orientation$ 
Horizontal=�.+��� $	��240������ *SIPI_DepartmentName+�� $��||���� $��30������ *
Regulation+�� $��Program Name��$
��Left=�$��	24,10,0,0q�$	��Top=�$��26��$	��102���� -   $ programNameCombobax��$
��Left=�$��
131,12,0,0q�$	��Top=�$	��238��#��[ ���� .R��� $ 
Horizontal=�.+��� $	��130������ *SIPI_ProgramName+�� $��Semester��$
��Left=�$��	768,8,0,0q�$	��Top=�$��26��$��65���� -   $ semesterCombobax��$
��Left=�$��
838,10,0,0q�$	��Top=�$��74��#��[ ���� .R��� $ 
Horizontal=�.+��� $��60������ *
SemesterNo+�� $��Bangla Course Name��$
��Left=�$��
131,97,0,0q�$	��Top=�$��26��$	��126���� -	    ��Name$ banglaCourseNameTextBox��$
��Left=�$��23��$��135,126,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��120���� $
��Code��$
��Left=�$��
277,97,0,0q�$	��Top=�$��26��$��45���� -
   $��courseCodeTextBox��$
��Left=�$��23��$��260,126,0,0q�$
 Wrap=�$�� ��$	��Top=�$��76���� $�� ��$
��Left=�$��
343,50,0,0q�$	��Top=�$	��130��$	��569��.��� .+��� $��Credit Info��$
��Left=�$��	10,10,0,0q�$	��Top=�$��88��$	��182��.��� $��0,0,-2,0q�.+��� $��Theory��$
��Left=�$��0,10,0,0q�$	��Top=�$��26��$��53���� -   $��theoryCreditTextBox��$
��Left=�$��23��$��0,34,0,0q�$
 Wrap=�$�� ��$	��Top=�$��53���� $��	Prectical��$
��Left=�$��	58,10,0,0q�$	��Top=�$��26��$��53���� -   $��precticalCreditTextBox��$
��Left=�$��23��$��	58,34,0,0q�$
 Wrap=�$�� ��$	��Top=�$��53���� -   $��TotalCreditTextBox��$
��Left=�$��23��$��
116,34,0,0q�$
 Wrap=�$�� ��$	��Top=�$��53���� $��Credit��$
��Left=�$��
116,10,0,0q�$	��Top=�$��26��$��53���� $��
Marks Info��$
��Left=�$��	197,0,0,0q�$	��Top=�$	��108��$	��360��.��� $��0,0,-2,0q�.+��� $��Theory��$
��Left=�$	��Top=�$��86��$	��147��.��� $��0,-9,-11,-12q�$��85��$	��Top=�$
��Left=�$	��146��.+��� $��Cont.��$
��Left=�$��17,5,0,0q�$	��Top=�$��25��$��43���� $��
Assessment��$
��Left=�$��0,16,0,0q�$	��Top=�$��24��$��99���� $��Final��$
��Left=�$��89,6,0,0q�$	��Top=�$��24��$��73���� $
��Exam��$
��Left=�$��	89,17,0,0q�$	��Top=�$��24��$��73���� -   $-��'theoryMarkasContinuousAssessmentTextbox��$
��Left=�$��23��$��	10,40,0,0q�$
 Wrap=�$�� ��$	��Top=�$��53���� -   $"��theoryMarkasFinalExamTextBox��$
��Left=�$��23��$��	80,40,0,0q�$
 Wrap=�$�� ��$	��Top=�$��53���� $��	Prectical��$
��Left=�$	��Top=�$��86��$	��147��$��	152,0,0,0q�.��� $��0,-9,-11,-12q�$��85��$	��Top=�$
��Left=�$	��146��.+��� $��Cont.��$
��Left=�$��17,5,0,0q�$	��Top=�$��25��$��43���� $��
Assessment��$
��Left=�$��0,16,0,0q�$	��Top=�$��24��$��75���� $��Final��$
��Left=�$��89,6,0,0q�$	��Top=�$��24��$��73���� $
��Exam��$
��Left=�$��	89,17,0,0q�$	��Top=�$��24��$��47���� -   $0��*PracticalMarkasContinuousAssessmentTextBox��$
��Left=�$��23��$��	10,40,0,0q�$
 Wrap=�$�� ��$	��Top=�$��53���� -   $%��PracticalMarkasFinalExamTextBox��$
��Left=�$��23��$��	80,40,0,0q�$
 Wrap=�$�� ��$	��Top=�$��53���� $��Total��$
��Left=�$��
306,18,0,0q�$	��Top=�$��24��$��36���� -   $��totalMarksTextbox��$
��Left=�$��25��$��
303,46,0,0q�$
 Wrap=�$�� ��$	��Top=�$��46���� -   $��submitButton��$
��Save��$
��Left=�$��837,191,0,0q�$	��Top=�$��75��$��22���� -    ��Name$ clearButton��$��Clear��$
��Left=�$��745,191,0,0q�$	��Top=�$��75��$��22��