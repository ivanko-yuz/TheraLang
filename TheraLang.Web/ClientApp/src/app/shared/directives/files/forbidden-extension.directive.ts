import { ValidatorFn, AbstractControl } from "@angular/forms";

export function forbiddenExtensionValidator(exts: RegExp): ValidatorFn {
  return (control: AbstractControl): { [key: string]: any } | null => {
    try {
      if (control.value == null) {
        return null;
      }
      const filename = control.value.files[0].name;
      const forbidden = exts.test(filename);
      return forbidden ? { forbiddenName: { value: filename } } : null;
    } catch (error) {}
  };
}
