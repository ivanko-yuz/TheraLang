/* tslint:disable:no-unused-variable */
import { async, TestBed } from '@angular/core/testing';
import { PiranhaPageComponent } from './piranha-page.component';
describe('PiranhaPageComponent', () => {
    let component;
    let fixture;
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [PiranhaPageComponent]
        })
            .compileComponents();
    }));
    beforeEach(() => {
        fixture = TestBed.createComponent(PiranhaPageComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=piranha-page.component.spec.js.map