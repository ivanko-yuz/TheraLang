import { Pipe, PipeTransform } from '@angular/core';
import { Project } from 'src/app/shared/models/project/project';

@Pipe({
  name: 'daysLeft'
})
export class DaysLeftPipe implements PipeTransform {

  transform(project: Project): any {
    let endDate = new Date(project.projectEnd);
    let timeLeft = endDate.getTime() - Date.now();
    
    if(timeLeft <= 0) return "Expired";

    let daysLeft = Math.ceil(timeLeft / (1000 * 3600 * 24));
    return daysLeft;
  }
}
