import { async, TestBed } from '@angular/core/testing';
import { GeneralResourcesTableComponent } from './general-resources-table.component';
describe('GeneralResourcesTableComponent', () => {
    let component;
    let fixture;
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [GeneralResourcesTableComponent]
        })
            .compileComponents();
    }));
    beforeEach(() => {
        fixture = TestBed.createComponent(GeneralResourcesTableComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=general-resources-table.component.spec.js.map