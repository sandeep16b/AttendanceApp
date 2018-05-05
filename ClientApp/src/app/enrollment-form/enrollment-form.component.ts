import { ClassTypeService } from './../services/class-type.service';
import { CourseService } from './../services/course.service';
import { ClassService } from './../services/class.service';
import { StudentService } from './../services/student.service';
import { EnrollmentService } from './../services/enrollment.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-enrollment-form',
  templateUrl: './enrollment-form.component.html',
  styleUrls: ['./enrollment-form.component.css']
})
export class EnrollmentFormComponent implements OnInit {
  class: any = {};
  classes: any[];
  students: any[];
  courses: any[];
  classTypes: any[];
  constructor(
    private courseService: CourseService, 
    private classService: ClassService, 
    private studentService: StudentService,
    private classTypeService: ClassTypeService) { }

  ngOnInit() {
    // this.enrollmentService.getEnrollments().subscribe(enrollments => {
    //   this.enrollments = enrollments;
    //   console.log("Enrollments ", this.enrollments);
    // });

    this.studentService.getStudents().subscribe(students => {
      this.students = students;
      console.log("Students ", this.students);
    }); 

    this.courseService.getCourses().subscribe(courses => {
      this.courses = courses;
      console.log("Courses: ", this.courses);
    }); 

    this.classService.getClasses().subscribe(classes => {
      this.classes = classes;
      console.log("Classes: ", this.classes);
    }); 

    this.classTypeService.getClassTypes().subscribe(classTypes => {
      this.classTypes = classTypes;
      var selectedEnrollment = console.log("Classes Types: ", this.classTypes);
      
    }); 
    
  }

  onClassTypeChange(){
    var selectedClassType = this.classTypes.find(m => m.id == this.class.classType);
    this.classes = selectedClassType ? selectedClassType.classes : [];
  }

}
