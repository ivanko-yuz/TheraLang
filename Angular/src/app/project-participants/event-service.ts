import { BehaviorSubject, Subject } from 'rxjs';
import { Injectable } from '@angular/core';
import { ProjectParticipationRequest } from './project-participation-request';
import { MatTableDataSource } from '@angular/material';

@Injectable()
export class EventService{

    private childClickedEvent = new Subject();
   
     emitChildEvent(){
        this.childClickedEvent.next()
     }
   
     childEventListner(){
        return this.childClickedEvent.asObservable();
      } 
   
   }

   
// @Injectable()
// export class EventService{

//     private childClickedEvent = new BehaviorSubject<MatTableDataSource<ProjectParticipationRequest>>(null);
   
//      emitChildEvent(p: MatTableDataSource<ProjectParticipationRequest>){
//         this.childClickedEvent.next(p)
//      }
   
//      childEventListner(){
//         return this.childClickedEvent.asObservable();
//       } 
   
//    }