import {
  GET_ALL_TASKS,
  ADD_TASK,
  PUT_TASK,
  DELETE_TASK
} from '../actionTypes';

export const getAllTasks = () => ({type: GET_ALL_TASKS});
export const addTask = (data) => ({type: ADD_TASK});
export const putTask = (data) => ({type: PUT_TASK});
export const deleteTask = (data) => ({type: DELETE_TASK}); 