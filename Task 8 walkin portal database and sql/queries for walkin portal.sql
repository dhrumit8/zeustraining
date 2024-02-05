use walkin_portal;
-- validating email
-- SELECT email FROM user_details
-- WHERE email REGEXP '^[A-Za-z0-9.]+@[A-Za-z0-9.]+\\.[A-Z|a-z]{2,4}$';

-- validating password
-- SELECT * FROM login
-- WHERE password REGEXP '^(?=.*[A-Z])(?=.*[a-z])(?=.*[^A-Za-z0-9]).{8,}$';

-- alter table table_name AUTO_INCREMENT = 1;

-- login query to validate user credentials
-- SELECT * from login
-- WHERE email = 'dhrumit.solanki@zeuslearning.com'
-- AND password = 'Dhrumit@123';

-- Registration query to add users data to the required tables

-- INSERT INTO user_details 
-- (first_name, last_name, email, country_code, phone_number, resume, profile_image, portfolio_url, referal, job_related_email)
-- VALUES ('John', 'Watson', 'johnwatson@example.com', '91', '9876543210', 'johnresume', 'johnimage', 'www.myportfolio.in', NULL, 1);

-- INSERT INTO login (id, email, password) VALUES (LAST_INSERT_ID(), 'johnwatson@example.com', 'John@123');

-- INSERT INTO user_has_job_roles VALUES (LAST_INSERT_ID(), 2);

-- INSERT INTO educational_qualifications (id, percentage, year_of_passing, qualification, stream_branch, college, college_location, user_details_user_id)
-- VALUES (LAST_INSERT_ID(), 65, 2020, 'Bachelor in Technology (B.Tech)', 'Information Technology', 'Pune Institute of Technology (PIT)', 'Pune', LAST_INSERT_ID());

-- INSERT INTO professional_qualification (id, fresher, experienced, user_details_user_id)
-- VALUES (last_insert_id(), 0, 1, last_insert_id());

-- INSERT INTO experienced_qualification (`years_of_experience`, `current_ctc`, `expected_ctc`, `on_notice_period`, `notice_period_end`, `notice_period_length`, `appered_for_zeus_test`, `role_applied`, `other_technologies_familiar`, `other_technologies_expertise`, `professional_qualification_id`)
-- VALUES (5, 500000, 650000, 1, '2020-05-20', 2, 0, NULL, NULL, NULL, last_insert_id());

-- INSERT INTO experienced_has_technologies_expertise (`experienced_qualification_id`, `technologies_expertise_id`) VALUES (1, 1);

-- INSERT INTO experienced_has_technologies_familiar (`experienced_qualification_id`, `technologies_familiar_id`) VALUES (1, 1);


-- INSERT INTO fresher_qualification (`appeared_for_zeus_test`, `role_applied_for_zeus_test`, `other_technologies_familiar`, `professional_qualification_id`)
-- VALUES (0, NULL, NULL, 2);


-- INSERT INTO fresher_has_technologies_familiar (`fresher_qualification_id`, `technologies_familiar_id`) VALUES (1, 1);


-- Displaying the user data

-- select user_id, first_name, last_name, email, country_code, phone_number, resume, profile_image, portfolio_url, referal, job_related_email, j.roles
-- from user_details u
-- left join user_has_job_roles ur
-- on u.user_id = ur.user_details_user_id
-- left join job_roles j
-- on ur.job_roles_id = j.id
-- ;

-- select u.user_id, j.roles
-- from user_details u
-- left join user_has_job_roles ur
-- on u.user_id = ur.user_details_user_id
-- left join job_roles j
-- on ur.job_roles_id = j.id
-- where u.user_id = 2
-- ;

-- select id, percentage, year_of_passing, qualification, stream_branch, college, college_location, user_details_user_id as user_id
-- from educational_qualifications eq
-- where user_details_user_id = 1
-- ;

-- select pq.id, fresher, experienced, fq.appeared_for_zeus_test, fq.role_applied_for_zeus_test, fq.other_technologies_familiar, years_of_experience, current_ctc, expected_ctc, on_notice_period, notice_period_end, notice_period_length, eq.appered_for_zeus_test, eq.role_applied, eq.other_technologies_familiar, eq.other_technologies_expertise
-- from professional_qualification pq
-- left join fresher_qualification fq
-- on pq.user_details_user_id = fq.professional_qualification_id
-- left join experienced_qualification eq
-- on pq.user_details_user_id = eq.professional_qualification_id
-- ;

-- select pq.id, fresher, experienced, fq.appeared_for_zeus_test, fq.role_applied_for_zeus_test, fq.other_technologies_familiar
-- from professional_qualification pq
-- join fresher_qualification fq
-- on pq.user_details_user_id = fq.professional_qualification_id
-- ;

-- select fq.id, fq.appeared_for_zeus_test, fq.role_applied_for_zeus_test, fq.other_technologies_familiar, ftf.fresher_qualification_id, tf.technologies
-- from fresher_qualification fq
-- left join fresher_has_technologies_familiar ftf
-- on ftf.fresher_qualification_id = fq.id
-- left join technologies_familiar tf
-- on ftf.technologies_familiar_id = tf.id
-- ;

-- select tf.technologies
-- from fresher_qualification fq
-- left join fresher_has_technologies_familiar ftf
-- on ftf.fresher_qualification_id = fq.id
-- left join technologies_familiar tf
-- on ftf.technologies_familiar_id = tf.id
-- where fq.id = 1
-- ;

-- select pq.id, fresher, experienced, years_of_experience, current_ctc, expected_ctc, on_notice_period, notice_period_end, notice_period_length, eq.appered_for_zeus_test, eq.role_applied, eq.other_technologies_familiar, eq.other_technologies_expertise
-- from professional_qualification pq
-- join experienced_qualification eq
-- on pq.user_details_user_id = eq.professional_qualification_id
-- ;

-- select pq.id, fresher, experienced, years_of_experience, current_ctc, expected_ctc, on_notice_period, notice_period_end, notice_period_length, eq.appered_for_zeus_test, eq.role_applied, eq.other_technologies_familiar, eq.other_technologies_expertise, tf.technologies
-- from professional_qualification pq
-- left join experienced_qualification eq
-- on pq.user_details_user_id = eq.professional_qualification_id
-- left join experienced_has_technologies_familiar etf
-- on etf.experienced_qualification_id = eq.id
-- left join technologies_familiar tf
-- on tf.id = etf.technologies_familiar_id
-- ;

-- select years_of_experience, current_ctc, expected_ctc, on_notice_period, notice_period_end, notice_period_length, eq.appered_for_zeus_test, eq.role_applied, eq.other_technologies_familiar, eq.other_technologies_expertise, tf.technologies
-- from experienced_qualification eq
-- left join experienced_has_technologies_familiar etf
-- on etf.experienced_qualification_id = eq.id
-- left join technologies_familiar tf
-- on tf.id = etf.technologies_familiar_id
-- ;

-- select tf.technologies
-- from experienced_qualification eq
-- left join experienced_has_technologies_familiar etf
-- on etf.experienced_qualification_id = eq.id
-- left join technologies_familiar tf
-- on tf.id = etf.technologies_familiar_id
-- where eq.id = 1
-- ;




-- Query to get the data for walk-in listing page

-- select j.id, job_title, start_date, end_date, location, special_opportunity, expires, ra.job_id, r.roles
-- from job j
-- left join roles_available ra
-- on j.id = ra.job_id
-- left join roles r
-- on ra.job_roles_id = r.id
-- ;

-- select r.roles
-- from job j
-- left join roles_available ra
-- on j.id = ra.job_id
-- left join roles r
-- on ra.job_roles_id = r.id
-- where j.id = 2
-- ;



-- Get the data for individual walk-in page

-- select id,roles from roles;

-- select j.id, job_title, start_date, end_date, location, special_opportunity, expires, r.roles, ts.slots
-- from job j
-- left join roles_available ra
-- on j.id = ra.job_id
-- left join roles r
-- on ra.job_roles_id = r.id
-- left join job_has_time_slots jts
-- on jts.job_id = j.id
-- left join time_slots ts
-- on ts.id = jts.time_slots_id
-- where j.id = 2
-- ;

-- select r.roles
-- from job j
-- left join roles_available ra
-- on j.id = ra.job_id
-- left join roles r
-- on ra.job_roles_id = r.id
-- where j.id = 2
-- ;

-- select ts.slots
-- from job j
-- left join job_has_time_slots jts
-- on jts.job_id = j.id
-- left join time_slots ts
-- on ts.id = jts.time_slots_id
-- where j.id = 2
-- ;

-- select j.id, jpr.general_instructions, jpr.instructions_for_exam, jpr.min_system_requirements, jpr.process
-- from job j
-- left join job_pre_requisites jpr
-- on j.job_pre_requisites_id = jpr.id
-- where j.id = 2
-- ;

-- select j.id, rd.gross_package, rd.role_description, rd.requirements
-- from job j
-- left join roles_available ra
-- on ra.job_id = j.id
-- left join roles r
-- on r.id = ra.job_roles_id
-- left join roles_detail rd
-- on rd.id = r.roles_detail_id
-- where j.id = 2
-- ;


-- Query to register for a walk-in

-- INSERT INTO user_applied_for_job (`user_details_user_id`, `job_id`, `time_slot_selected`, `resume`, `venue_details_id`)
-- VALUES (2, 2, '9:00 AM to 11:00 AM', 'johnresume', 1);

-- INSERT INTO user_applied_for_job_has_roles_preferences (`user_id`, `job_id`, `roles_id`)
-- VALUES (2, 2, 1);



-- Query to get the walk-in hall tickets

-- select uaj.user_details_user_id, uaj.job_id, uaj.time_slot_selected, j.start_date, vd.venue, vd.things_to_remember
-- from user_applied_for_job uaj
-- left join job j
-- on j.id = uaj.job_id
-- left join venue_details vd
-- on vd.id = uaj.venue_details_id
-- ;








