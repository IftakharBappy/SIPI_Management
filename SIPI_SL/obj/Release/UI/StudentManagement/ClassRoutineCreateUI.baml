   M S B A M L   `   `   `  ����   SIPI_SL7    1SIPI_SL.UI.StudentManagement.ClassRoutineCreateUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Class Routine Create UI��$	��747��$
��1229��   	GrayWhite#��[   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=�.��� $��Center=�$��21,0,2,4q�$
��1198��.+��� $��Class Routine��$
��Left=�$��	10,10,0,0q�$	��Top=�$��3q�$	��238��$
��1169��.��� .+��� -   $��rutinTabControl��.@��� -   $��CreateRoutineTabItem��$��Group Create��
�������$��-2,-2,-2,-7q�.���  � ColumnDefinitions �� .+��� $��Program��$
��Left=�$��	61,25,0,0q�$	��Top=��� -   $��programCombobox��$
��Left=�$��
162,27,0,0q�$	��Top=�$	��206��$��28������ .R���  �� Orientation$ 
Horizontal=�.+��� $	��206������ *SIPI_ProgramName+�� $��
Department��$
��Left=�$��	61,57,0,0q�$	��Top=��� -   $��departmentCombobox��$
��Left=�$��
162,57,0,0q�$	��Top=�$	��206��$��27������ .R��� $ 
Horizontal=�.+��� $	��206������ *SIPI_DepartmentName+�� $��Semester��$
��Left=�$��	61,83,0,0q�$	��Top=��� -   $��semesterCombobox��$
��Left=�$��
162,86,0,0q�$	��Top=�$	��206��$��28������ .R��� $ 
Horizontal=�.+��� $	��110������ *
SemesterNo+�� $
��Year��$
��Left=�$��
391,23,0,0q�$	��Top=� J� RenderTransformOrigin$ 	3.636,0.5&��� -   $��yearTextBox��$��Right=�$��29��$��
0,29,536,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120���� -   $��addignButton��$	��Add��$
��Left=�$��
540,63,0,0q�$	��Top=�$��75���� -    ��Name$ clearButton��$��Clear��$
��Left=�$��
540,92,0,0q�$	��Top=�$��75���� -	   $��routinTabItem��$��Routin Entry��$��
1,-2,-5,-7q�.��� .+��� -
   $��
newRoutine��$��New Routine��$
��Left=�$	��Top=�$	��106��$��	651,8,0,0q��� $	��Day��$
��Left=�$	��Top=�$��	28,10,0,0q�$ 
-0.233,0.5&��� -   $��dayCombobox��$
��Left=�$	��Top=�$	��191��$��	63,14,0,0q�.@��� $��Saturday���� $��Sunday���� $��Monday���� $��Tuesday���� $��	Wednesday���� $��Thursday���� $��Class��$
��Left=�$	��Top=�$��	10,81,0,0q�$ 0.216,0.654&��� $��Course Name��$
��Left=�$	��Top=�$��
10,104,0,0q��� $��Teacher's Name��$
��Left=�$	��Top=�$��
10,130,0,0q�$ 1.967,0.577&��� $��	1st Class��$
��Left=�$��
104,67,0,0q�$	��127��$��98��$	��Top=�.��� .+��� -   $��firstClassCombobox��$
��Left=�$	��Top=�$	��115������ .R��� $ 
Horizontal=�.+��� $��20������ *
PeriodName+�� $	��|| ���� $��30������ *	StartTime+�� -   $��firstCourseCombobox��$
��Left=�$	��Top=�$	��115��$��0,27,0,0q����� .R��� $ 
Horizontal=�.+��� $	��147������ *
CourseName+�� -   $��firstTeacherCombobox��$
��Left=�$	��Top=�$	��115��$��0,54,0,0q�$ -1.132,-0.545&����� .R��� $ 
Horizontal=�.+��� $	��100������ *TeacherName+�� $��	2nd Class��$
��Left=�$��
236,67,0,0q�$	��128��$��98��$	��Top=�.��� .+��� -   $��secondClassComboBox��$
��Left=�$	��Top=�$	��116������ .R��� $ 
Horizontal=�.+��� $��20������ *
PeriodName+�� $	��|| ���� $��30������ *	StartTime+�� -   $��secondCourseCombobox��$
��Left=�$	��Top=�$	��117��$��	-1,27,0,0q����� .R��� $ 
Horizontal=�.+��� $	��147������ *
CourseName+�� -   $��secondTeacherCombobox��$
��Left=�$	��Top=�$	��117��$��	-1,54,0,0q����� .R��� $ 
Horizontal=�.+��� $	��100������ *TeacherName+�� $��	3rd Class��$
��Left=�$��
369,67,0,0q�$	��127��$��98��$	��Top=�.��� .+��� -   $��thirdClassCombobox��$
��Left=�$	��Top=�$	��115������ .R��� $ 
Horizontal=�.+��� $��20������ *
PeriodName+�� $	��|| ���� $��30������ *	StartTime+�� -   $��thirdCourseCombobox��$
��Left=�$	��Top=�$	��116��$��	-1,27,0,0q����� .R��� $ 
Horizontal=�.+��� $	��147������ *
CourseName+�� -   $��thirdTeacherCombobox��$
��Left=�$	��Top=�$	��115��$��0,54,0,0q����� .R��� $ 
Horizontal=�.+��� $	��100������ *TeacherName+�� $��	4th Class��$
��Left=�$��
501,67,0,0q�$	��128��$��98��$	��Top=�.��� .+��� -   $��forthClassCombobox��$
��Left=�$	��Top=�$	��116������ .R��� $ 
Horizontal=�.+��� $��20������ *
PeriodName+�� $	��|| ���� $��30������ *	StartTime+�� -   $��forthCourseCombobox��$
��Left=�$	��Top=�$	��115��$��1,27,0,0q����� .R��� $ 
Horizontal=�.+��� $	��147������ *
CourseName+�� -   $��forthTeacherCombobox��$
��Left=�$	��Top=�$	��115��$��1,54,0,0q����� .R��� $ 
Horizontal=�.+��� $	��100������ *TeacherName+�� $��	5th Class��$
��Left=�$��
634,69,0,0q�$	��123��$��98��$	��Top=�.��� .+��� -   $��fifthClassCombobox��$
��Left=�$	��Top=�$	��111������ .R��� $ 
Horizontal=�.+��� $��20������ *
PeriodName+�� $	��|| ���� $��30������ *	StartTime+�� -   $��fifthCourseCombobox��$
��Left=�$	��Top=�$	��111��$��0,27,0,0q����� .R��� $ 
Horizontal=�.+��� $	��140������ *
CourseName+�� -   $��fifthTeacherCombobox��$
��Left=�$	��Top=�$	��111��$��0,54,0,0q����� .R��� $ 
Horizontal=�.+��� $	��100������ *TeacherName+�� $��	6th Class��$
��Left=�$��
762,67,0,0q�$	��122��$��98��$	��Top=�.��� .+��� -   $��sixthClassCombobox��$
��Left=�$	��Top=�$	��110������ .R��� $ 
Horizontal=�.+��� $��20������ *
PeriodName+�� $	��|| ���� $��30������ *	StartTime+�� -   $��sixthCourseCombobox��$
��Left=�$	��Top=�$	��110��$��0,27,0,0q����� .R��� $ 
Horizontal=�.+��� $	��140������ *
CourseName+�� -   $��sixthTeacherCombobox��$
��Left=�$	��Top=�$	��110��$��0,54,0,0q����� .R��� $ 
Horizontal=�.+��� $	��100������ *TeacherName+�� $��	7th Class��$
��Left=�$��
889,67,0,0q�$	��122��$��98��$	��Top=�.��� .+��� -   $��seventhClassCombox��$
��Left=�$	��Top=�$	��110������ .R��� $ 
Horizontal=�.+��� $��20������ *
PeriodName+�� $	��|| ���� $��30������ *	StartTime+�� -   $��seventhCourseCombobox��$
��Left=�$	��Top=�$	��110��$��0,27,0,0q����� .R��� $ 
Horizontal=�.+��� $	��140������ *
CourseName+�� -    $��seventhTeacherCombobox��$
��Left=�$	��Top=�$	��110��$��0,54,0,0q����� .R��� $ 
Horizontal=�.+��� $	��100������ *TeacherName+�� $��	8th Class��$
��Left=�$��1016,67,0,0q�$	��122��$��98��$	��Top=�.��� .+��� -!   $��eighthClassCombobox��$
��Left=�$	��Top=�$	��110��$ 	0.5,0.227&����� .R��� $ 
Horizontal=�.+��� $��20������ *
PeriodName+�� $	��|| ���� $��30������ *	StartTime+�� -"   $��eightCourseCombobox��$
��Left=�$	��Top=�$	��110��$��0,27,0,0q����� .R��� $ 
Horizontal=�.+��� $	��140������ *
CourseName+�� -#   $��eighthTeacherCombobox��$
��Left=�$	��Top=�$	��110��$��0,54,0,0q����� .R��� $ 
Horizontal=�.+��� $	��100������ *TeacherName+�� -$   $
��Save��$
��Left=�$	��Top=�$��75��$��1104,253,0,0q��� -%   $��Clear��$
��Left=�$	��Top=�$��75��$��1024,253,0,0q��� -&   $��allRoutineListView��$
��Left=�$	��387��$��
10,278,0,0q�$	��Top=�$
��1169��   alternatingListViewItemStyle#��[ 	 � ContextMenu	 �� -'   
 ��Name$
 ZoneIformationList�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -(    m�Name$ RemoveContextMenu��$��Remove�� �� View ��  �� AllowsColumnReorder . .P��� $�� �� �� Width$ 0�� �� DisplayMemberBinding �� *Id+�� $��
Department��$	 200�� �� *DepartmentName+�� $��	Semester ��$ 65�� �� *
SemesterNo+�� $
��Day ��$ 50�� �� *Day+�� $��Year ��$ 50�� �� *Year+�� $	 150��$��	1st class�� �� CellTemplate �� .R��� ��`�  �� StringFormat$ {0}
{1}
{2}��.1���  �� Path$ FirstClassStart��� $ FirstCourseName��� $ FirstTeacherName��� $	 150��$��	2nd Class�� �� .R��� ��`� $ {0}
{1}
{2}��.1��� $ SecondClassStart��� $ SecondCourseName��� $ SecondTeacherName��� $	 150��$��	3rd Class�� �� .R��� ��`� $ {0}
{1}
{2}��.1��� $ ThirdClassStart��� $ ThirdCourseName��� $ ThirdTeacherrName��� $	 150��$��	4th Class�� �� .R��� ��`� $ {0}
{1}
{2}��.1��� $ ForthClassStart��� $ ForthCourseName��� $ ForthTeacherrName��� $	 150��$��	4th Class�� �� .R��� ��`� $ {0}
{1}
{2}��.1��� $ ForthClassStart��� $ ForthCourseName��� $ ForthTeacherrName��� $	 150��$��	5th Class�� �� .R��� ��`� $ {0}
{1}
{2}��.1��� $ FifthClassStart��� $ FifthCourseName��� $ FifthTeacherrName��� $	 150��$��	6th Class�� �� .R��� ��`� $ {0}
{1}
{2}��.1��� $ SixthClassStart��� $ SixthCourseName��� $ SixthTeacherrName��� $	 150��$��	7th Class�� �� .R��� ��`� $ {0}
{1}
{2}��.1��� $ SeventhClassStart��� $ SeventhCourseName��� $ SeventhTeacherrName��� $	 150��$��	8th Class�� �� .R��� ��`� $ {0}
{1}
{2}��.1��� $ EighthClassStart��� $ EighthCourseName��� $ EighthTeacherrName��� -)   $��teacherSearch��$
��Left=�$��970,670,0,0q�$	��Top=�$	��209��$��29���� $
��Bold"�$"��Search per Teacher All Class��$
��Left=�$��730,670,0,0q�$	��Top=�$	��225��$��14(�$��Segoe Script)�